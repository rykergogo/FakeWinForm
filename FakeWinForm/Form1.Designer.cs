namespace FakeWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            progressBar1 = new ProgressBar();
            browseBtn = new Button();
            pathTxtBox = new TextBox();
            installBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Software Installation";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 134);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(251, 23);
            progressBar1.TabIndex = 1;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(206, 57);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(57, 23);
            browseBtn.TabIndex = 2;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // pathTxtBox
            // 
            pathTxtBox.Location = new Point(12, 58);
            pathTxtBox.Name = "pathTxtBox";
            pathTxtBox.Size = new Size(188, 23);
            pathTxtBox.TabIndex = 3;
            pathTxtBox.Text = "Enter Path to Install...";
            pathTxtBox.MouseDown += pathTxtBox_MouseDown;
            // 
            // installBtn
            // 
            installBtn.Location = new Point(100, 95);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(75, 23);
            installBtn.TabIndex = 4;
            installBtn.Text = "Install";
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += installBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 176);
            Controls.Add(installBtn);
            Controls.Add(pathTxtBox);
            Controls.Add(browseBtn);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Install Wizard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Button browseBtn;
        private TextBox pathTxtBox;
        private Button installBtn;
    }
}