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
    public partial class Frm_pay : Form
    {
        public Frm_pay()
        {
            InitializeComponent();

            bill_id();
            LoadStudentID();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string sql;

        private void LoadStudentID()
        {
            try
            {
                con.Open();
                string sql = "SELECT Id_st FROM tb_register"; // เปลี่ยนชื่อ table ให้ถูก
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                txt_idstudent.Items.Clear(); // ล้างข้อมูลเก่าใน ComboBox
                while (dr.Read())
                {
                    txt_idstudent.Items.Add(dr["Id_st"].ToString()); // เพิ่มข้อมูลใน ComboBox
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

        public void bill_id()
        {
            try
            {
                con.Open();
                sql = "SELECT MAX(Id_st) FROM tb_pay";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_idstudent.Text = "bill-000000";
                }
                else
                {
                    int inval = int.Parse(maxid.Substring(2, 6));
                    inval++;
                    txt_bill.Text = string.Format("bill-{0:000001}", inval);
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
            sql = "SELECT Id_st as 'ໄອດີນັກຮຽນ', Fee as 'ຄ່າຮຽນ', Class as 'ຫ້ອງຮຽນ', Date as 'ວັນທີ່ຈ່າຍ',Price as 'ລາຄາ',Bill as'ໃບບິນ',Status as 'ສະຖານະການຈ່າຍ' FROM tb_pay ORDER BY Id_st ASC";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tb_pay (Id_st, Fee, Class, Date, Price, Bill, Status) " +
                         "VALUES(@Id_st,@Fee,@Class,@Date,@Price,@Bill,@Status)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id_st", txt_idstudent.Text);
                cmd.Parameters.AddWithValue("@Fee", txt_fee.Text);
                cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                cmd.Parameters.AddWithValue("@Bill", txt_bill.Text);
                cmd.Parameters.AddWithValue("@Status", txt_status.Text);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("ບັນທຶກຂໍ້ມູນສໍຳເລັດ");

            bill_id();
            txt_idstudent.Text = "";
            txt_fee.Text = "";
            txt_classroom.Text = "";
            txt_price.Text = "";
            txt_bill.Text = "";
            txt_status.Text = "";
            txt_idstudent.Select();

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_idstudent.Text =
dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_fee.Text =
dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_classroom.Text =
dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text =
dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_price.Text =
dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_bill.Text =
 dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_status.Text =
 dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_idstudent.Select();
                btn_save.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tb_pay SET Id_st=@Id_st, Fee=@Fee, Class=@Class, Date=@Date, Price=@Price, Bill=@Bill, Status=@Status  WHERE Id_st='" + txt_idstudent.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id_st", txt_idstudent.Text);
            cmd.Parameters.AddWithValue("@Fee", txt_fee.Text);
            cmd.Parameters.AddWithValue("@Class", txt_classroom.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);
            cmd.Parameters.AddWithValue("@Bill", txt_bill.Text);
            cmd.Parameters.AddWithValue("@Status", txt_status.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            bill_id();
            txt_idstudent.Text = "";
            txt_fee.Text = "";
            txt_classroom.Text = "";
            txt_price.Text = "";
            txt_bill.Text = "";
            txt_status.Text = "";
            txt_idstudent.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;"))
            {
                con.Open();
                string sql = "DELETE FROM tb_pay  WHERE Id_st = @Id_st";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id_st", txt_idstudent.Text);
                cmd.ExecuteNonQuery();
            }

            // ເອີ້ນໃຊ້ຟັນຊັນ ລົບຂໍ້ມູນ ແລະ ອໍໂຕ່ໄອດີ
            check_dgv();        // ກວດສອບການລົບຂໍ້ມູນໃນກໍລະນີບໍ່ມີຂໍ້ມູນໃຫ້ລົບແລ້ວ
            bill_id();
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
                txt_idstudent.Text = "";
                txt_fee.Text = "";
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_bill.Text = "";
                txt_status.Text = "";
                txt_idstudent.Select();
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
                txt_idstudent.Text = "";
                txt_fee.Text = "";
                txt_classroom.Text = "";
                txt_price.Text = "";
                txt_bill.Text = "";
                txt_status.Text = "";
                txt_idstudent.Select();
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
            Id_st AS 'ໄອດີນັກຮຽນ', 
            Fee AS 'ຄ່າຮຽນ', 
            Class AS 'ຫ້ອງຮຽນ', 
            Date AS 'ວັນທີ່ຈ່າຍ', 
            Price AS 'ລາຄາ', 
            Bill AS 'ໃບບິນ', 
            Status AS 'ສະຖານະການຈ່າຍ'
        FROM tb_pay
        WHERE  Id_st LIKE @search 
            OR Class LIKE @search 
            OR Status LIKE @search";

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

        private void btn_bill_Click(object sender, EventArgs e)
        {
  
            string studentId = txt_idstudent.Text;  // ค่า Id ที่เลือกไว้
            view_bill vb = new view_bill(studentId);
            vb.Show();   // หรือ vb.ShowDialog();
            this.Hide();
        }

        private void txt_idstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_idstudent.SelectedIndex == -1) return;

            try
            {
                con.Open();
                string sql = "SELECT Class, Price FROM tb_register WHERE Id_st = @Id_st";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id_st", txt_idstudent.SelectedValue ?? txt_idstudent.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_classroom.Text = reader["Class"].ToString();
                    txt_price.Text = reader["Price"].ToString();
                }
                else
                {
                    txt_classroom.Text = "";
                    txt_price.Text = "";
                }
                reader.Close();
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
    }
}
