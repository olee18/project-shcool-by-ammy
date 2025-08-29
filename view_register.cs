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
    public partial class view_register : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog=final2025; Integrated Security=SSPI;");
        public view_register()
        {
            InitializeComponent();
        }

        private void view_register_Load(object sender, EventArgs e)
        {
            LoadReport();
        }
        private void LoadReport() //ສ້າງຟັງຊັນໂຫຼດລາຍງານຈາກຖານຂໍ້ມູນ
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM tb_register";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_register");

                Regiter_all rpt = new Regiter_all();// ຊື່ລາຍງານທີ່ສ້າງ
                rpt.SetDataSource(ds.Tables["tb_register"]);
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

                string sql = "SELECT * FROM tb_register WHERE Id_st LIKE @search OR Class LIKE @search";//ປ້ອງກັນ SQL Injection
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@search", "%" + txt_search.Text.Trim() + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_register");

                Regiter_all rpt = new Regiter_all();// ຊື່ລາຍງານທີ່ສ້າງ
                rpt.SetDataSource(ds.Tables["tb_register"]);
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

        private void btn_logout_Click(object sender, EventArgs e)
        {

            frm_admin_menu a1 = new frm_admin_menu();
            a1.Show();
            this.Hide();


        }
    }
}
