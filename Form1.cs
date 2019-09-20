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
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & start_e.bat";
            myProcess.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & start.bat";
            myProcess.Start();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string der = "profile3.conf";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & apply.bat " + der;
            myProcess.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string der = "profile1.conf";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & apply.bat " + der;
            myProcess.Start();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string der = "profile2.conf";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & apply.bat " + der;
            myProcess.Start();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            string der = "Profile3";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & data.bat " + der;
            myProcess.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string der = "Profile1";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & data.bat " + der;
            myProcess.Start();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            string der = "profile1.conf";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & edit.bat " + der;
            myProcess.Start();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            string der = "profile2.conf";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & edit.bat " + der;
            myProcess.Start();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            string der = "profile3.conf";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & edit.bat " + der;
            myProcess.Start();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            string der = "Profile2";
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + Application.StartupPath + "/Scripts/ & data.bat " + der;
            myProcess.Start();
        }
    }
}
