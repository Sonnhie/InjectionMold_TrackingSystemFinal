using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace InjectionMold_TrackingSystem
{
    public partial class Splashscreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomrect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Splashscreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar1.Value = 0;
        }
        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 2;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
            if ( circularProgressBar1.Value == 10)
            {
                label2.Text = "Loading resources...";
            }
            if (circularProgressBar1.Value == 20)
            {
                label2.Text = "Preparing database...";
            }
            if (circularProgressBar1.Value == 60)
            {
                label2.Text = "Please be Patient...";
            }
            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
