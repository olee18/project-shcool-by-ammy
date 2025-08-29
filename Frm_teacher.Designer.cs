
namespace project2025
{
    partial class frm_teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_teacher));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_educetion = new System.Windows.Forms.TextBox();
            this.txt_numberparent = new System.Windows.Forms.TextBox();
            this.txt_nameparent = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(976, 103);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Hinsiew Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 67);
            this.label1.TabIndex = 25;
            this.label1.Text = "ຂໍ້ມູນອາຈານ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 148);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ພາກສ່ວນສະແດງຂໍ້ມູນ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_educetion);
            this.groupBox2.Controls.Add(this.txt_numberparent);
            this.groupBox2.Controls.Add(this.txt_nameparent);
            this.groupBox2.Controls.Add(this.txt_number);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.txt_age);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(985, 258);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ພາກສ່ວນປ້ອນຂໍ້ມູນ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 40);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txt_educetion
            // 
            this.txt_educetion.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_educetion.Location = new System.Drawing.Point(671, 208);
            this.txt_educetion.Name = "txt_educetion";
            this.txt_educetion.Size = new System.Drawing.Size(240, 40);
            this.txt_educetion.TabIndex = 17;
            // 
            // txt_numberparent
            // 
            this.txt_numberparent.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberparent.Location = new System.Drawing.Point(671, 162);
            this.txt_numberparent.Name = "txt_numberparent";
            this.txt_numberparent.Size = new System.Drawing.Size(240, 40);
            this.txt_numberparent.TabIndex = 16;
            // 
            // txt_nameparent
            // 
            this.txt_nameparent.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameparent.Location = new System.Drawing.Point(671, 116);
            this.txt_nameparent.Name = "txt_nameparent";
            this.txt_nameparent.Size = new System.Drawing.Size(240, 40);
            this.txt_nameparent.TabIndex = 15;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(671, 70);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(240, 40);
            this.txt_number.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(671, 24);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(240, 40);
            this.txt_address.TabIndex = 13;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(162, 153);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(236, 40);
            this.txt_age.TabIndex = 11;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(162, 103);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(236, 40);
            this.txt_username.TabIndex = 10;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(162, 52);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(236, 40);
            this.txt_id.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(525, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "ລະດັບການສຶກສາ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(527, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 32);
            this.label10.TabIndex = 7;
            this.label10.Text = "ເບີໂທຜູ້ປົກຄອງ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "ຊື່ຜູ້ປົກຄອງ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "ເບີໂທ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "ບ້ານເມືອງແຂວງ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "ວັນເດືອນປີເກີດ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "ອາຍຸ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຊື່ແລະນາມສະກຸນ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ໄອດີ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Controls.Add(this.btn_menu);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_show);
            this.groupBox3.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(985, 186);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ພາກສ່ວນຈັດການຂໍ້ມູນ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(793, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "ພິມຂໍ້ມູນໃສ່ເພື່ອຄົ້ນຫາ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Red;
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(786, 135);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 45);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Red;
            this.btn_menu.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_menu.Location = new System.Drawing.Point(630, 83);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(150, 100);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.Text = "MENU";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(475, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 100);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Red;
            this.btn_update.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_update.Location = new System.Drawing.Point(318, 83);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 100);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Red;
            this.btn_save.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(159, 83);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 100);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "SAVE";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Red;
            this.btn_show.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_show.Location = new System.Drawing.Point(3, 80);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(150, 100);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "SHOW";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // frm_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txt_educetion;
        private System.Windows.Forms.TextBox txt_numberparent;
        private System.Windows.Forms.TextBox txt_nameparent;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}