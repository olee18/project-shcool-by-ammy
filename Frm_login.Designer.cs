
namespace project2025
{
    partial class frm_login
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Hinsiew Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "ເຂົ້າສູ່ລະບົບ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hinsiew Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຜູ້ໃຊ້ງານ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hinsiew Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "ລະຫັດຜ່ານ";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Hinsiew RegularItalic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(266, 125);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(241, 51);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Hinsiew RegularItalic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(266, 227);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(241, 51);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_login.Font = new System.Drawing.Font("Hinsiew RegularItalic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Image = global::project2025.Properties.Resources.User_Login_64;
            this.btn_login.Location = new System.Drawing.Point(109, 300);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 105);
            this.btn_login.TabIndex = 5;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.Font = new System.Drawing.Font("Hinsiew RegularItalic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Image = global::project2025.Properties.Resources.Clear_64;
            this.btn_clear.Location = new System.Drawing.Point(555, 300);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 105);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.Font = new System.Drawing.Font("Hinsiew RegularItalic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Image = global::project2025.Properties.Resources.Logout_64;
            this.btn_logout.Location = new System.Drawing.Point(325, 300);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(126, 105);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_login;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_clear;
    }
}