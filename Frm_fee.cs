using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project2025
{
    public partial class Frm_fee : Form
    {
        public Frm_fee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string sql;

        private void btn_show_Click(object sender, EventArgs e)
        {
                con.Open();
                sql = "SELECT Class as 'ຫ້ອງຮຽນ', Price as 'ລາຄາ' FROM tb_fee ORDER BY Class ASC";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tb_fee(Class,Price)VALUES(@Class,@Price)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ບັນທຶກຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            txt_classroom.Text = "";
            txt_price.Text = "";
            txt_classroom.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_classroom.Text =
dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_price.Text =
dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_classroom.Select();
                btn_save.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tb_fee SET Class=@Class, Price=@Price WHERE Class='" + txt_classroom.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            txt_classroom.Text = "";
            txt_price.Text = "";
            txt_classroom.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;"))
            {
                con.Open();
                string sql = "DELETE FROM tb_fee  WHERE Class = @Class";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
                cmd.ExecuteNonQuery();
            }

            // ເອີ້ນໃຊ້ຟັນຊັນ ລົບຂໍ້ມູນ ແລະ ອໍໂຕ່ໄອດີ
            check_dgv();        // ກວດສອບການລົບຂໍ້ມູນໃນກໍລະນີບໍ່ມີຂໍ້ມູນໃຫ້ລົບແລ້ວ
            btn_save.Enabled = true;
            // ໂຫລດຂໍ້ມູນເຂົ້າ DataGridView
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void check_dgv() //ການກວດສອບການລົບຂໍ້ມູນ 
        {
            int i = dataGridView1.RowCount;
            if (i <= 0)
            {
                MessageBox.Show("ບໍ່ມີຂໍ້ມູນໃຫ້ລົບແລ້ວ");
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_classroom.Select();
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_classroom.Select();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            string searchText = txt_search.Text.Trim(); // Remove leading/trailing spaces
            string sql = @"
        SELECT 
            Class AS 'ຫ້ອງຮຽນ', 
            Price AS 'ລາຄາ'
        FROM tb_fee
        WHERE  Class LIKE @search  
            OR Price LIKE @search";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            frm_admin_menu a1 = new frm_admin_menu();
                a1.Show();
            this.Hide();

        }
    }
    }
    
    

        























































































































































































































































































































































































































































































        
