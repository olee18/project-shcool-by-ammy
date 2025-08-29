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
    public partial class frm_room : Form
    {
        public frm_room()
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
                sql = "SELECT MAX(Id) FROM tb_classroom";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_id.Text = "R-000001";
                }
                else
                {
                    int inval = int.Parse(maxid.Substring(2, 6));
                    inval++;
                    txt_id.Text = string.Format("R-{0:000000}", inval);
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
            sql = "SELECT Id as 'ໄອດີ', Class as 'ຫ້ອງຮຽນ' FROM tb_classroom ORDER BY Id ASC";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tb_classroom (Id,Class)VALUES(@Id,@Class)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", txt_id.Text);
            cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);

            con.Open(); // 🔴 You forgot this
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("ບັນທຶກຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            txt_id.Text = "";
            txt_classroom.Text = "";
            txt_id.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_id.Text =
dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_classroom.Text =
dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_id.Select();
                btn_save.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tb_classroom  SET Id=@Id, Class=@Class WHERE Id='" + txt_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", txt_id.Text);
            cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            txt_id.Text = "";
            txt_classroom.Text = "";
            txt_id.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;"))
            {
                con.Open();
                string sql = "DELETE FROM tb_classroom  WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", txt_id.Text);
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
                txt_id.Text = "";
                txt_classroom.Text = "";
                txt_id.Select();
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
                txt_id.Text = "";
                txt_classroom.Text = "";
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
            class AS 'ຫ້ອງຮຽນ' 
        FROM tb_classroom
        WHERE Id LIKE @search 
            OR class LIKE @search";

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

