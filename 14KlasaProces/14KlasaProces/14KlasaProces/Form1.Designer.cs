namespace _14KlasaProces
{
    partial class Form1
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
            this.InternetExplorerStartButton = new System.Windows.Forms.Button();
            this.ExcelStartButton = new System.Windows.Forms.Button();
            this.WordStartButton = new System.Windows.Forms.Button();
            this.startInfoStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InternetExplorerStartButton
            // 
            this.InternetExplorerStartButton.Location = new System.Drawing.Point(24, 22);
            this.InternetExplorerStartButton.Name = "InternetExplorerStartButton";
            this.InternetExplorerStartButton.Size = new System.Drawing.Size(149, 23);
            this.InternetExplorerStartButton.TabIndex = 0;
            this.InternetExplorerStartButton.Text = "Pokrenite Internet Explorer";
            this.InternetExplorerStartButton.UseVisualStyleBackColor = true;
            this.InternetExplorerStartButton.Click += new System.EventHandler(this.InternetExplorerStartButton_Click);
            // 
            // ExcelStartButton
            // 
            this.ExcelStartButton.Location = new System.Drawing.Point(223, 22);
            this.ExcelStartButton.Name = "ExcelStartButton";
            this.ExcelStartButton.Size = new System.Drawing.Size(100, 23);
            this.ExcelStartButton.TabIndex = 1;
            this.ExcelStartButton.Text = "Pokrenite Excel";
            this.ExcelStartButton.UseVisualStyleBackColor = true;
            this.ExcelStartButton.Click += new System.EventHandler(this.ExcelStartButton_Click);
            // 
            // WordStartButton
            // 
            this.WordStartButton.Location = new System.Drawing.Point(24, 83);
            this.WordStartButton.Name = "WordStartButton";
            this.WordStartButton.Size = new System.Drawing.Size(149, 23);
            this.WordStartButton.TabIndex = 2;
            this.WordStartButton.Text = "Pokrenite Word";
            this.WordStartButton.UseVisualStyleBackColor = true;
            this.WordStartButton.Click += new System.EventHandler(this.WordStartButton_Click);
            // 
            // startInfoStartButton
            // 
            this.startInfoStartButton.Location = new System.Drawing.Point(223, 83);
            this.startInfoStartButton.Name = "startInfoStartButton";
            this.startInfoStartButton.Size = new System.Drawing.Size(100, 23);
            this.startInfoStartButton.TabIndex = 3;
            this.startInfoStartButton.Text = "StartInfo";
            this.startInfoStartButton.UseVisualStyleBackColor = true;
            this.startInfoStartButton.Click += new System.EventHandler(this.startInfoStartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 127);
            this.Controls.Add(this.startInfoStartButton);
            this.Controls.Add(this.WordStartButton);
            this.Controls.Add(this.ExcelStartButton);
            this.Controls.Add(this.InternetExplorerStartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InternetExplorerStartButton;
        private System.Windows.Forms.Button ExcelStartButton;
        private System.Windows.Forms.Button WordStartButton;
        private System.Windows.Forms.Button startInfoStartButton;
    }
}

