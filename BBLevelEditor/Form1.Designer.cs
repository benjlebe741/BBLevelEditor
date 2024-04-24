namespace BBLevelEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.buildButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 578);
            this.panel1.TabIndex = 0;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(268, 39);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(67, 31);
            this.button25.TabIndex = 23;
            this.button25.Text = "5";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DarkRed;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(416, 150);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(196, 143);
            this.button23.TabIndex = 21;
            this.button23.Text = "1";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // buildButton
            // 
            this.buildButton.BackColor = System.Drawing.Color.YellowGreen;
            this.buildButton.FlatAppearance.BorderSize = 0;
            this.buildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildButton.ForeColor = System.Drawing.Color.Black;
            this.buildButton.Location = new System.Drawing.Point(1220, 667);
            this.buildButton.Margin = new System.Windows.Forms.Padding(4);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(67, 31);
            this.buildButton.TabIndex = 6;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = false;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1300, 711);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button23;
    }
}

