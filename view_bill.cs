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
using CrystalDecisions.CrystalReports.Engine; //ນຳເຂົ້າ libary ຂອງ CrystalReports

namespace project2025
{
    public partial class view_bill : Form

    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog=final2025; Integrated Security=SSPI;");
        public view_bill()
        {
            InitializeComponent();
        }

        public view_bill(string studentId) // รับค่าเข้ามา
        {
            InitializeComponent();
            txt_search.Text = studentId;   // เอาค่าไปใส่ใน textbox เลย
            txt_search.Text = studentId;
            SearchAndLoadReport(); // ค้นหาอัตโนมัติ
        }
    
    private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_admin_menu a1 = new frm_admin_menu();
            a1.Show();
            this.Hide();

        }

        private void view_bill_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_search.Text))
            {
                SearchAndLoadReport();
            }
            else
            {
                LoadReport(); // ถ้าไม่มีค่า ก็ดึงทั้งหมด
            }
        }
        private void LoadReport() //ສ້າງຟັງຊັນໂຫຼດລາຍງານຈາກຖານຂໍ້ມູນ
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM tb_pay";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_pay");

                bill rpt = new  bill();// ຊື່ລາຍງານທີ່ສ້າງ
                rpt.SetDataSource(ds.Tables["tb_pay"]);
                crystalReportViewer1.ReportSource = rpt; // ຊື່ໂຕສະແດງລາຍງານຢູ່ໜ້າຟອມ
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ຜິດພາດ: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchAndLoadReport();
        }
        private void SearchAndLoadReport()
        {
            try
            {
                con.Open();

                string sql = "SELECT * FROM tb_pay WHERE Id_st LIKE @search OR Bill LIKE @search";//ປ້ອງກັນ SQL Injection
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@search", "%" + txt_search.Text.Trim() + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_pay");

                bill rpt = new bill();// ຊື່ລາຍງານທີ່ສ້າງ
                rpt.SetDataSource(ds.Tables["tb_pay"]);
                crystalReportViewer1.ReportSource = rpt; // ຊື່ໂຕສະແດງລາຍງານຢູ່ໜ້າຟອມ
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ຜິດພາດ: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
