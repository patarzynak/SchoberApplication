namespace SchoberApplication
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cTextBox1 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.cTextBox2 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.signinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schober";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cTextBox1
            // 
            this.cTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.cTextBox1.Location = new System.Drawing.Point(294, 235);
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Size = new System.Drawing.Size(150, 20);
            this.cTextBox1.TabIndex = 5;
            this.cTextBox1.WaterMark = "Username";
            this.cTextBox1.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox1.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // cTextBox2
            // 
            this.cTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.cTextBox2.Location = new System.Drawing.Point(294, 288);
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Size = new System.Drawing.Size(150, 20);
            this.cTextBox2.TabIndex = 6;
            this.cTextBox2.WaterMark = "Password";
            this.cTextBox2.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox2.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox2.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(322, 341);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(92, 24);
            this.signinButton.TabIndex = 7;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.cTextBox2);
            this.Controls.Add(this.cTextBox1);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ChreneLib.Controls.TextBoxes.CTextBox cTextBox1;
        private ChreneLib.Controls.TextBoxes.CTextBox cTextBox2;
        private System.Windows.Forms.Button signinButton;
    }
}