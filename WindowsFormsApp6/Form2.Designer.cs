namespace WindowsFormsApp6
{
    partial class loginForm2
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
            this.login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.studentC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(167, 226);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(106, 52);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "سنا";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "459462";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(126, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(27, 13);
            this.name.TabIndex = 3;
            this.name.Text = "user";
            // 
            // studentC
            // 
            this.studentC.AutoSize = true;
            this.studentC.Location = new System.Drawing.Point(92, 143);
            this.studentC.Name = "studentC";
            this.studentC.Size = new System.Drawing.Size(57, 13);
            this.studentC.TabIndex = 4;
            this.studentC.Text = "passsword";
            // 
            // loginForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.studentC);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.login);
            this.Name = "loginForm2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label studentC;
    }
}