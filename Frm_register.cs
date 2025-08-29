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
    public partial class Frm_register : Form
    {
        public Frm_register()
        {
            InitializeComponent();
            Auto_id();
            LoadStudentID();
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
                sql = "SELECT MAX(Id_reg) FROM tb_register";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_reg.Text = "R-000001";
                }
                else
                {
                    int inval = int.Parse(maxid.Substring(2, 6));
                    inval++;
                    txt_reg.Text = string.Format("R-{0:000000}", inval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadStudentID()
        {
            try
            {
                con.Open();
                string sql = "SELECT s_id FROM tb_student"; // เปลี่ยนชื่อ table ให้ถูก
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                txt_id.Items.Clear(); // ล้างข้อมูลเก่าใน ComboBox
                while (dr.Read())
                {
                    txt_id.Items.Add(dr["s_id"].ToString()); // เพิ่มข้อมูลใน ComboBox
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    

private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sql = "SELECT Id_reg AS 'ລະຫັດ', " +
                      "Id_st AS 'ໄອດີນັກຮຽນ', " +
                      "Class AS 'ຫ້ອງຮຽນ', " +
                      "Reg_Date AS 'ວັນທີ່ລົງທະບຽນ', " +
                      "Price AS 'ລາຄາ' " +
                      "FROM tb_register ORDER BY Id_reg ASC";

                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sql = "INSERT INTO tb_register (Id_reg, Id_st, Class, Reg_Date, Price) " +
                      "VALUES(@Id_reg, @Id_st, @Class, @Reg_Date, @Price)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id_reg", txt_reg.Text);
                cmd.Parameters.AddWithValue("@Id_st", txt_id.Text);
                cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
                cmd.Parameters.AddWithValue("@Reg_Date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("ບັນທຶກຂໍ້ມູນສໍາເລັດ");

                // โหลดข้อมูลใหม่มาแสดง
                sql = "SELECT Id_reg AS 'ລະຫັດ', Id_st AS 'ໄອດີນັກຮຽນ', Class AS 'ຫ້ອງຮຽນ', " +
                      "Reg_Date AS 'ວັນທີ່ລົງທະບຽນ', Price AS 'ລາຄາ' " +
                      "FROM tb_register ORDER BY Id_reg ASC";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                Auto_id(); // Auto generate รหัสใหม่
             
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_reg.Select();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_id.Text =
dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_reg.Text =
dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_classroom.Text =
dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text =
dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_price.Text =
dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_reg.Select();
                btn_save.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tb_register SET Id_st=@Id_st, Class=@Class, Reg_Date=@Reg_Date, Price=@Price  WHERE Id_reg='" + txt_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id_reg", txt_id.Text);
            cmd.Parameters.AddWithValue("@Id_st", txt_reg.Text);
            cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
            cmd.Parameters.AddWithValue("@Reg_Date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            Auto_id();
            txt_reg.Text = "";
            txt_classroom.Text = "";
            txt_price.Text = "";
            txt_reg.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;"))
            {
                con.Open();
                string sql = "DELETE FROM tb_register  WHERE Id_reg = @Id_reg";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id_reg", txt_id.Text);
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
                txt_reg.Text = "";
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_reg.Select();
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
                txt_reg.Text = "";
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_reg.Select();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            string searchText = txt_search.Text.Trim(); // Remove leading/trailing spaces
            string sql = @"SELECT 
            Id_reg AS 'ໄອດີ', 
            Id_st AS 'ໄອດີນັກຮຽນ', 
            Class AS 'ຫ້ອງຮຽນ', 
            Reg_Date AS 'ວັນທີ່ລົງທະບຽນ', 
            Price AS 'ລາຄາ' 
        FROM tb_register
        WHERE Id LIKE @search 
            OR  Class LIKE @search 
            OR Price LIKE @search";
            //==============================

          
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

    

    
