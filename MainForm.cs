using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DOSBox_Launcher_Next
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", @Application.StartupPath + @"/dosboxrun-cfg.bat");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(@Application.StartupPath + @"/dosboxrun-cfg.bat");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            File.Delete(@Application.StartupPath + @"\DOSBox\dosbox.conf");
            File.Copy(@Application.StartupPath + @"\DOSBox\d2m2.conf", @Application.StartupPath + @"\DOSBox\dosbox.conf");
            MessageBox.Show("Configuration is applied successfully!", "Game: Doom II: Hell on Earth", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            File.Delete(@Application.StartupPath + @"\DOSBox\dosbox.conf");
            File.Copy(@Application.StartupPath + @"\DOSBox\dn3d.conf", @Application.StartupPath + @"\DOSBox\dosbox.conf");
            MessageBox.Show("Configuration is applied successfully!", "Game: Duke Nukem 3D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            File.Delete(@Application.StartupPath + @"\DOSBox\dosbox.conf");
            File.Copy(@Application.StartupPath + @"\DOSBox\d2m.conf", @Application.StartupPath + @"\DOSBox\dosbox.conf");
            MessageBox.Show("Configuration is applied successfully!", "Game: Doom", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", @Application.StartupPath + @"\DOSData\D2M2");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", @Application.StartupPath + @"\DOSData\DN3D");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", @Application.StartupPath + @"\DOSBox\dn3d.conf");
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", @Application.StartupPath + @"\DOSBox\d2m.conf");
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", @Application.StartupPath + @"\DOSBox\d2m2.conf");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", @Application.StartupPath + @"\DOSData\D2M");
        }
    }
}
