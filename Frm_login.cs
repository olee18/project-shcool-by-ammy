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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                MessageBox.Show("ກາລຸນາຕື່ມຂໍ້ມູນໃສ່ໃຫ້ຄົບຖ້ວນ");
                txt_username.Text = "";
                txt_password.Text = "";
                txt_username.Select();
            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("ກາລຸນາຕື່ມຂໍ້ມູນໃສ່ໃຫ້ຄົບຖ້ວນ");
                txt_username.Text = "";
                txt_password.Text = "";
                txt_username.Select();
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0UAPKPB; Initial Catalog=final2025; Integrated Security = SSPI; "); //ຈຸດເຊື່ອມຕໍ່ກັບ 

                    SqlCommand cmd = new SqlCommand("SELECT user_status FROM tb_login WHERE user_name=@user_name and user_password=@user_password", con); //ເລືອກຂໍ້ມູນຈາກຕາຕະລາງ 
                    cmd.Parameters.AddWithValue("@user_name", txt_username.Text);
                   cmd.Parameters.AddWithValue("@user_password", txt_password.Text);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string status = result.ToString();
                        MessageBox.Show($"Login ສຳເລັດ! ທ່ານເປັນ {status}",
"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (status == "Admin")
                        {
                            frm_admin_menu adminForm = new frm_admin_menu();
                            adminForm.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ຊື່ຜູ້ໃຊ້ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ");
                        txt_username.Text = "";
                        txt_password.Text = "";
                        txt_username.Select();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}

