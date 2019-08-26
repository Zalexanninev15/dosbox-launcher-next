using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DOSBox_Launcher_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("edit_dosboxstart.bat");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("dosbox.bat");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Process.Start("apply3.bat");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Process.Start("apply1.bat");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Process.Start("apply2.bat");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("profile3_data.bat");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("profile1_data.bat");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("edit1.bat");
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("edit2.bat");
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("edit3.bat");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("profile2_data.bat");
        }
    }
}
