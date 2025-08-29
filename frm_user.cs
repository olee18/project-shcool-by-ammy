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
    public partial class frm_user : Form
    {
        public frm_user()
        {
            InitializeComponent();
            Auto_id();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string sql;
        public void Auto_id()
        {
            try
            {
                con.Open();
                sql = "SELECT MAX(id) FROM tb_user";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_id.Text = "U-000001";
                }
                else
                {
                    int inval = int.Parse(maxid.Substring(2, 6));
                    inval++;
                    txt_id.Text = string.Format("U-{0:000000}", inval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "SELECT Id  as 'ໄອດີ', name as 'ຊື່', password as 'ລະຫັດ' FROM tb_user ORDER BY Id ASC";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tb_user(Id, name, password) VALUES(@Id, @name, @password)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", txt_id.Text.Trim());
            cmd.Parameters.AddWithValue("@name", txt_username.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txt_password.Text.Trim());

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");

            Auto_id();
          
            txt_username.Text = "";
            txt_password.Text = "";
            txt_id.Select();

            // Reload data
            //string loadSql = "SELECT * FROM tb_user";
            //using (SqlDataAdapter da = new SqlDataAdapter(loadSql, con))
            //{
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            //}
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_id.Text =
dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_username.Text =
dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_password.Text =
 dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_id.Select();
                btn_save.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tb_user SET name = @name, password = @password WHERE Id = @Id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", txt_id.Text.Trim());
            cmd.Parameters.AddWithValue("@name", txt_username.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txt_password.Text.Trim());

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open(); // ✅ Open the connection
            cmd.ExecuteNonQuery(); // ✅ Now safe to execute
            con.Close();

            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ");

            Auto_id();
          
            txt_username.Text = "";
            txt_password.Text = "";
            txt_id.Select();

            // ✅ Reload updated data
            //string loadSql = "SELECT * FROM tb_user";
            //using (SqlDataAdapter da = new SqlDataAdapter(loadSql, con))
            //{
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            //}
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;"))
            {
                con.Open();
                string sql = "DELETE FROM tb_user WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", txt_id.Text);
                cmd.ExecuteNonQuery();
            }

            // ເອີ້ນໃຊ້ຟັນຊັນ ລົບຂໍ້ມູນ ແລະ ອໍໂຕ່ໄອດີ
            check_dgv();        // ກວດສອບການລົບຂໍ້ມູນໃນກໍລະນີບໍ່ມີຂໍ້ມູນໃຫ້ລົບແລ້ວ
            Auto_id();
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
                txt_id.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
                txt_id.Select();
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
                txt_id.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
                txt_id.Select();
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
            Id AS 'ໄອດີ', 
            name AS 'ຊື່', 
            password AS 'ລະຫັດ'
        FROM tb_user
        WHERE  Id LIKE @search 
            OR name LIKE @search 
            OR password LIKE @search";

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

