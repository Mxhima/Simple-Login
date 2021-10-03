
namespace LoginWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PwdtxtBox = new System.Windows.Forms.TextBox();
            this.UsrtxtBox = new System.Windows.Forms.TextBox();
            this.UsrLbl = new System.Windows.Forms.Label();
            this.PwdLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PwdtxtBox
            // 
            this.PwdtxtBox.Location = new System.Drawing.Point(414, 131);
            this.PwdtxtBox.Name = "PwdtxtBox";
            this.PwdtxtBox.Size = new System.Drawing.Size(192, 20);
            this.PwdtxtBox.TabIndex = 2;
            // 
            // UsrtxtBox
            // 
            this.UsrtxtBox.Location = new System.Drawing.Point(414, 87);
            this.UsrtxtBox.Name = "UsrtxtBox";
            this.UsrtxtBox.Size = new System.Drawing.Size(192, 20);
            this.UsrtxtBox.TabIndex = 3;
            // 
            // UsrLbl
            // 
            this.UsrLbl.AutoSize = true;
            this.UsrLbl.Location = new System.Drawing.Point(310, 87);
            this.UsrLbl.Name = "UsrLbl";
            this.UsrLbl.Size = new System.Drawing.Size(76, 15);
            this.UsrLbl.TabIndex = 4;
            this.UsrLbl.Text = "USERNAME";
            // 
            // PwdLbl
            // 
            this.PwdLbl.AutoSize = true;
            this.PwdLbl.Location = new System.Drawing.Point(310, 136);
            this.PwdLbl.Name = "PwdLbl";
            this.PwdLbl.Size = new System.Drawing.Size(76, 15);
            this.PwdLbl.TabIndex = 5;
            this.PwdLbl.Text = "PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 426);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PwdLbl);
            this.Controls.Add(this.UsrLbl);
            this.Controls.Add(this.UsrtxtBox);
            this.Controls.Add(this.PwdtxtBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LOGIN WINDOW";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PwdtxtBox;
        private System.Windows.Forms.TextBox UsrtxtBox;
        private System.Windows.Forms.Label UsrLbl;
        private System.Windows.Forms.Label PwdLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

