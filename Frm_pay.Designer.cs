
namespace project2025
{
    partial class Frm_pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pay));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_bill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.txt_idstudent = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_classroom = new System.Windows.Forms.TextBox();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_fee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Hinsiew Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 55);
            this.label1.TabIndex = 27;
            this.label1.Text = "ຂໍ້ມູນການຈ່າຍ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_bill);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Controls.Add(this.btn_menu);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_show);
            this.groupBox3.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 542);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(980, 142);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ພາກສ່ວນຈັດການຂໍ້ມູນ";
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.Purple;
            this.btn_bill.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bill.Image = ((System.Drawing.Image)(resources.GetObject("btn_bill.Image")));
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bill.Location = new System.Drawing.Point(676, 41);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(111, 100);
            this.btn_bill.TabIndex = 6;
            this.btn_bill.Text = "Bill";
            this.btn_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
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
            this.txt_search.BackColor = System.Drawing.Color.Purple;
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(786, 96);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 45);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Purple;
            this.btn_menu.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_menu.Location = new System.Drawing.Point(560, 44);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(111, 100);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.Text = "MENU";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Purple;
            this.btn_delete.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(420, 44);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 100);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Purple;
            this.btn_update.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_update.Location = new System.Drawing.Point(270, 44);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 100);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(137, 41);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 100);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "SAVE";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Purple;
            this.btn_show.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_show.Location = new System.Drawing.Point(6, 41);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(112, 100);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "SHOW";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_status);
            this.groupBox2.Controls.Add(this.txt_idstudent);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_classroom);
            this.groupBox2.Controls.Add(this.txt_bill);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.txt_fee);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 333);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ພາກສ່ວນປ້ອນຂໍ້ມູນ";
            // 
            // txt_status
            // 
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "ຈ່າຍສົດ",
            "ເງິນໂອນ"});
            this.txt_status.Location = new System.Drawing.Point(696, 215);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(249, 45);
            this.txt_status.TabIndex = 15;
            this.txt_status.SelectedIndexChanged += new System.EventHandler(this.txt_idstudent_SelectedIndexChanged);
            // 
            // txt_idstudent
            // 
            this.txt_idstudent.FormattingEnabled = true;
            this.txt_idstudent.Location = new System.Drawing.Point(27, 95);
            this.txt_idstudent.Name = "txt_idstudent";
            this.txt_idstudent.Size = new System.Drawing.Size(249, 45);
            this.txt_idstudent.TabIndex = 15;
            this.txt_idstudent.SelectedIndexChanged += new System.EventHandler(this.txt_idstudent_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 45);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txt_classroom
            // 
            this.txt_classroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_classroom.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_classroom.Location = new System.Drawing.Point(359, 95);
            this.txt_classroom.Name = "txt_classroom";
            this.txt_classroom.ReadOnly = true;
            this.txt_classroom.Size = new System.Drawing.Size(259, 40);
            this.txt_classroom.TabIndex = 13;
            // 
            // txt_bill
            // 
            this.txt_bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bill.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill.Location = new System.Drawing.Point(696, 136);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.ReadOnly = true;
            this.txt_bill.Size = new System.Drawing.Size(249, 40);
            this.txt_bill.TabIndex = 13;
            // 
            // txt_price
            // 
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_price.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(696, 56);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(249, 40);
            this.txt_price.TabIndex = 10;
            // 
            // txt_fee
            // 
            this.txt_fee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fee.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fee.Location = new System.Drawing.Point(27, 198);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(249, 40);
            this.txt_fee.TabIndex = 9;
            this.txt_fee.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(733, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "ສະຖານະການຈ່າຍ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(783, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "ໃບບິນ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "ວັນທີ່ຈ່າຍ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(788, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "ລາຄາ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "ຄ່າຮຽນ";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຫ້ອງຮຽນ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hinsiew Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ໄອດີນັກຮຽນ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 177);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ພາກສ່ວນສະແດງຂໍ້ມູນ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(976, 121);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Frm_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "Frm_pay";
            this.Text = "Frm_pay";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.ComboBox txt_idstudent;
        private System.Windows.Forms.TextBox txt_classroom;
        private System.Windows.Forms.ComboBox txt_status;
    }
}