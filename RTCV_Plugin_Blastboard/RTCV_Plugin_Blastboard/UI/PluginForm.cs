namespace BLASTBOARD.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NLog;
    using RTCV.CorruptCore;

    using RTCV.Common;
    using RTCV.UI;
    using static RTCV.CorruptCore.RtcCore;
    using RTCV.Vanguard;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Runtime.InteropServices;
    using System.Drawing.Imaging;
    using RTCV.NetCore;
    using RTCV.UI.Modular;
    using System.Reflection;

    public partial class PluginForm : ComponentForm, IColorize
    {
        public BLASTBOARD plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        List<(string, StashKey)> loadedStashKeys = null;
        Size DefaultSize;

        public PluginForm(BLASTBOARD _plugin)
        {
            plugin = _plugin;

            this.InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.PluginForm_FormClosing);


            this.Text = BLASTBOARD.CamelCase(nameof(BLASTBOARD).Replace("_", " "));
            this.version.Text = $"{plugin.Version.ToString()}"; //automatic window title

            DefaultSize = btnOriginalSize.Size;
            btnOriginalSize.Visible = false;
        }


        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(HideOnClose)
            {
                e.Cancel = true;
                this.Hide();
            }    
        }


        private void Emu_Step(object sender, RealTimeEventArgs e)
        {
            //eval workflow here
        }

        private bool isPixelIdentical(Bitmap frame1, Bitmap frame2, Point location)
        {
            return (frame1.GetPixel(location.X, location.Y) == frame2.GetPixel(location.X, location.Y));
        }

        private bool isImageIdentical(Bitmap frame1, Bitmap frame2)
        {
            return CompareMemCmp(frame1, frame2);
        }

        [DllImport("msvcrt.dll")]
        private static extern int memcmp(IntPtr b1, IntPtr b2, long count);

        public static bool CompareMemCmp(Bitmap b1, Bitmap b2)
        {
            if ((b1 == null) != (b2 == null)) return false;
            if (b1.Size != b2.Size) return false;

            var bd1 = b1.LockBits(new Rectangle(new Point(0, 0), b1.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var bd2 = b2.LockBits(new Rectangle(new Point(0, 0), b2.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                IntPtr bd1scan0 = bd1.Scan0;
                IntPtr bd2scan0 = bd2.Scan0;

                int stride = bd1.Stride;
                int len = stride * b1.Height;

                return memcmp(bd1scan0, bd2scan0, len) == 0;
            }
            finally
            {
                b1.UnlockBits(bd1);
                b2.UnlockBits(bd2);
            }
        }

        private void Emu_GameClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("Emu_GameClosed");
        }

        private void Emu_GameLoaded(object sender, EventArgs e)
        {

        }

        private void PluginForm_Load(object sender, EventArgs e)
        {

            //var emu = LocalNetCoreRouter.QueryRoute<IRealTime>(RTCV.NetCore.Endpoints.Vanguard, RTCV.NetCore.Commands.Emulator.GetRealtimeAPI, null, true);

            //emu.GameLoaded += Emu_GameLoaded;
            //emu.GameClosed += Emu_GameClosed;
            //emu.StepHandler += Emu_Step;

            btnRefresh_Click(null, null);
        }

        private void btnOriginalSize_Click(object sender, EventArgs e)
        {
            LocalNetCoreRouter.Route(RTCV.NetCore.Endpoints.Vanguard, RTCV.NetCore.Commands.Remote.SetApplyCorruptBL, null, true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var dgv = S.GET<StockpileManagerForm>().dgvStockpile;

            List<StashKey> sks = new List<StashKey>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var sk = (row.Cells[0].Value as StashKey);

                if (sk == null)
                    continue;

                sks.Add(sk);
            }

            LoadFromStashKeys(sks);
        }

        public void LoadFromStashKeys(List<StashKey> sks)
        {
            List<(string, StashKey)> stashkeys = new List<(string, StashKey)>();

            foreach (var sk in sks)
            {
                var bl = sk.BlastLayer;

                if (bl == null || bl.Layer.Count == 0)
                    continue;

                stashkeys.Add((sk.Alias, sk));
            }


            loadedStashKeys = stashkeys;

            RefreshButtons();
        }

        private void RefreshButtons()
        {

            pnButtons.Controls.Clear();

            int ColumnsPerRows = (pnButtons.Size.Width - (pnButtons.Size.Width % DefaultSize.Width)) / DefaultSize.Width;

            int Padding = pnButtons.Location.X;
            for(int i=0; i< loadedStashKeys.Count; i++)
            {
                var req = loadedStashKeys[i];

                Button btn = btnOriginalSize.Clone();

                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = btn.BackColor;
                //btn.BackColor = Color.Gainsboro;
                btn.Size = DefaultSize;
                btn.Text = req.Item1;
                btn.Click += Btn_Click;
                btn.Tag = req.Item2;
                btn.Visible = true;

                if (ColumnsPerRows == 0)
                    ColumnsPerRows = 1;

                int column = (i % ColumnsPerRows);
                int row = (i - column) / ColumnsPerRows;


                pnButtons.Controls.Add(btn);
                btn.Location = new Point(column * DefaultSize.Width, row * DefaultSize.Height);
                btn.Show();

            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            StashKey sk = btn.Tag as StashKey;

            if (cbBlastToCorruptCloudLive.Checked)
            {
                LocalNetCoreRouter.Route("CORRUPTCLOUD_LIVERTC", "SEND_TO_CORRUPTCLOUDLIVE", sk, false);
            }
            else
            {
                LocalNetCoreRouter.Route(RTCV.NetCore.Endpoints.CorruptCore, RTCV.NetCore.Commands.Basic.ApplyBlastLayer, new object[] { sk.BlastLayer, false, false }, false);
            }
        }

        private void PluginForm_ResizeEnd(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void btnRefreshPlayer_Click(object sender, EventArgs e)
        {
            var dgv = S.GET<StockpilePlayerForm>().dgvStockpile;

            List<StashKey> sks = new List<StashKey>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var sk = (row.Cells[0].Value as StashKey);

                if (sk == null)
                    continue;

                sks.Add(sk);
            }

            LoadFromStashKeys(sks);
        }

    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }

}
