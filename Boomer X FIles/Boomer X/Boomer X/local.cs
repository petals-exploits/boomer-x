using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoobhaxxApi;

namespace Boomer_X
{
    public partial class local : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMoveable_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public local()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoobApi.Fly();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoobApi.Noclip();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NoobApi.IY();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NoobApi.Fire();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NoobApi.Smoke();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NoobApi.Sparkles();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NoobApi.RevizAdmin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NoobApi.TopKekV4();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NoobApi.RemoveLimbs();
        }

        private void local_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            NoobApi.Btools();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NoobApi.ForceField();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NoobApi.KillRoblox();
        }
    }
}
