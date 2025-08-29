
namespace project2025
{
    partial class frm_room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_room));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_classroom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LimeGreen;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Hinsiew Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1006, 67);
            this.label5.TabIndex = 31;
            this.label5.Text = "ຂໍ້ມູນຫ້ອງຮຽນ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_classroom);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(985, 270);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ພາກສ່ວນປ້ອນຂໍ້ມູນ";
            // 
            // txt_classroom
            // 
            this.txt_classroom.Location = new System.Drawing.Point(340, 161);
            this.txt_classroom.Name = "txt_classroom";
            this.txt_classroom.Size = new System.Drawing.Size(265, 45);
            this.txt_classroom.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(340, 56);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(265, 45);
            this.txt_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຫ້ອງຮຽນ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ໄອດີ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 148);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ພາກສ່ວນສະແດງຂໍ້ມູນ";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Controls.Add(this.btn_menu);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_show);
            this.groupBox3.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 494);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(985, 186);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ພາກສ່ວນຈັດການຂໍ້ມູນ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hinsiew Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(793, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "ພິມຂໍ້ມູນໃສ່ເພື່ອຄົ້ນຫາ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.LimeGreen;
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(786, 135);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 45);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_menu.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_menu.Location = new System.Drawing.Point(630, 86);
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
            this.btn_delete.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_delete.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(474, 86);
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
            this.btn_update.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_update.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_update.Location = new System.Drawing.Point(318, 86);
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
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.Font = new System.Drawing.Font("Hinsiew Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(162, 83);
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
            this.btn_show.BackColor = System.Drawing.Color.LimeGreen;
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
            // frm_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Name = "frm_room";
            this.Text = "frm_room";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_classroom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
    }
}