namespace WindowsFormsApp1
{
    partial class frmsignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatricNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconPassword = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Compact Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // txtfullName
            // 
            this.txtfullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtfullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfullName.Font = new System.Drawing.Font("SF Compact Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullName.ForeColor = System.Drawing.Color.Black;
            this.txtfullName.Location = new System.Drawing.Point(14, 146);
            this.txtfullName.Name = "txtfullName";
            this.txtfullName.Size = new System.Drawing.Size(254, 27);
            this.txtfullName.TabIndex = 1;
            this.txtfullName.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Compact Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matric Number";
            // 
            // txtmatricNo
            // 
            this.txtmatricNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtmatricNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmatricNo.Font = new System.Drawing.Font("SF Compact Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricNo.ForeColor = System.Drawing.Color.Black;
            this.txtmatricNo.Location = new System.Drawing.Point(14, 203);
            this.txtmatricNo.Name = "txtmatricNo";
            this.txtmatricNo.Size = new System.Drawing.Size(254, 27);
            this.txtmatricNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Compact Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("SF Compact Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(14, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(254, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Compact Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password";
            // 
            // txtconPassword
            // 
            this.txtconPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtconPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconPassword.Font = new System.Drawing.Font("SF Compact Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconPassword.ForeColor = System.Drawing.Color.Black;
            this.txtconPassword.Location = new System.Drawing.Point(14, 321);
            this.txtconPassword.Name = "txtconPassword";
            this.txtconPassword.PasswordChar = '●';
            this.txtconPassword.Size = new System.Drawing.Size(254, 27);
            this.txtconPassword.TabIndex = 4;
            this.txtconPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconPassword_KeyPress);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Location = new System.Drawing.Point(22, 356);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(121, 20);
            this.showPassword.TabIndex = 5;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(210)))));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.Font = new System.Drawing.Font("SF Compact Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(187, 399);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(81, 39);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next →";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Already Have an Account?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(57, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Back to Login";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(227)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("SF Compact Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(251, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "🔴";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmsignUp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.txtconPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmatricNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Compact Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmsignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmsignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatricNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconPassword;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
    }
}

