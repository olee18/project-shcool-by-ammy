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
    public partial class frm_teacher : Form
    {
        public frm_teacher()
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
                sql = "SELECT MAX(t_id) FROM tb_teacher";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_id.Text = "T-000001";
                }
                else
                {
                    int inval = int.Parse(maxid.Substring(2, 6));
                    inval++;
                    txt_id.Text = string.Format("T-{0:000000}", inval);
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
            sql = "SELECT t_id as 'ລະຫັດ', Name as 'ຊື່', Age as 'ອາຍຸ', Brith as 'ວັນ/ເດືອນ/ປີເກີດ', Number as 'ເບີໂທລະສັບ',Village as 'ບ້ານ', Name_parents as 'ຊື່ຜູ້ປົກຄອງ',Number_parents as 'ເບີຜູ້ປົກຄອງ',Educetionn_background as 'ລະດັບການສຶກສາ' FROM tb_teacher ORDER BY t_id ASC";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tb_teacher (t_id, Name, Age, Brith, Number,Village,Name_parents,Number_parents,Educetionn_background)VALUES(@t_id,@Name, @Age, @Brith, @Number,@Village,@Name_parents,@Number_parents,@Educetionn_background)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@t_id", txt_id.Text);
            cmd.Parameters.AddWithValue("@Name", txt_username.Text);
            cmd.Parameters.AddWithValue("@Age", txt_age.Text);
            cmd.Parameters.AddWithValue("@Brith", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@Village", txt_address.Text);
            cmd.Parameters.AddWithValue("@Number", txt_number.Text);
            cmd.Parameters.AddWithValue("@Name_parents", txt_nameparent.Text);
            cmd.Parameters.AddWithValue("@Number_parents", txt_numberparent.Text);
            cmd.Parameters.AddWithValue("@Educetionn_background", txt_educetion.Text);

            con.Open(); // 🔴 You forgot this
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("ບັນທຶກຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            Auto_id();
            txt_username.Text = "";
            txt_age.Text = "";
            txt_address.Text = "";
            txt_number.Text = "";
            txt_nameparent.Text = "";
            txt_numberparent.Text = "";
            txt_educetion.Text = "";
            txt_username.Select();
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
                txt_username.Text =
dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_age.Text =
dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text =
dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_address.Text =
dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_number.Text =
 dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_nameparent.Text =
dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_numberparent.Text =
dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_educetion.Text =
 dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txt_username.Select();
                btn_save.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tb_teacher SET Name=@Name, Age=@Age, Brith=@Brith, Village=@Village, Number=@Number, Name_parents=@Name_parents, Number_parents=@Number_parents ,Educetionn_background=@Educetionn_background  WHERE T_id='" + txt_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@t_id", txt_id.Text);
            cmd.Parameters.AddWithValue("@Name", txt_username.Text);
            cmd.Parameters.AddWithValue("@Age", txt_age.Text);
            cmd.Parameters.AddWithValue("@Brith", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@Number", txt_address.Text);
            cmd.Parameters.AddWithValue("@Village", txt_number.Text);
            cmd.Parameters.AddWithValue("@Name_parents", txt_nameparent.Text);
            cmd.Parameters.AddWithValue("@Number_parents", txt_numberparent.Text);
            cmd.Parameters.AddWithValue("@Educetionn_background", txt_educetion.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສໍຳເລັດ");
            con.Close();
            Auto_id();
            txt_username.Text = "";
            txt_age.Text = "";
            txt_address.Text = "";
            txt_number.Text = "";
            txt_nameparent.Text = "";
            txt_numberparent.Text = "";
            txt_educetion.Text = "";
            txt_username.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog = final2025; Integrated Security = SSPI;"))
            {
                con.Open();
                string sql = "DELETE FROM tb_teacher WHERE t_id = @t_id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@t_id", txt_id.Text);
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
                txt_username.Text = "";
                txt_age.Text = "";
                txt_address.Text = "";
                txt_number.Text = "";
                txt_nameparent.Text = "";
                txt_numberparent.Text = "";
                txt_educetion.Text = "";
                txt_username.Select();
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
                txt_username.Text = "";
                txt_age.Text = "";
                txt_address.Text = "";
                txt_number.Text = "";
                txt_nameparent.Text = "";
                txt_numberparent.Text = "";
                txt_educetion.Text = "";
                txt_username.Select();
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
            t_id AS 'ລະຫັດ', 
            Name AS 'ຊື່', 
            Age AS 'ອາຍຸ', 
            Brith AS 'ວັນ/ເດືອນ/ປີເກີດ', 
            Number AS 'ເບີໂທລະສັບ', 
            Village AS 'ບ້ານ', 
            Name_parents AS 'ຊື່ຜູ້ປົກຄອງ', 
            Number_parents AS 'ເບີຜູ້ປົກຄອງ',
            Educetionn_background AS 'ລະດັບການສຶກສາ'
        FROM tb_teacher
        WHERE Name LIKE @search 
            OR Number LIKE @search 
            OR Name_parents LIKE @search";

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





