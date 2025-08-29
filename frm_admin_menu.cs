using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2025
{
    public partial class frm_admin_menu : Form
    {
        public frm_admin_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_Click_1(object sender, EventArgs e)
        {
            frm_user a = new frm_user();
            a.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Frm_register a = new Frm_register();
            a.Show();
            this.Hide();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Frm_student a = new Frm_student();
            a.Show();
            this.Hide();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            frm_teacher a = new frm_teacher();
            a.Show();
            this.Hide();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            frm_room a = new frm_room();
            a.Show();
            this.Hide();
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            Frm_fee a = new Frm_fee();
            a.Show();
            this.Hide();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Frm_pay a = new Frm_pay();
            a.Show();
            this.Hide();
        }

        private void btn_view_bill_Click(object sender, EventArgs e)
        {
            view_bill a = new view_bill();
            a.Show();
            this.Hide();
        }

        private void btn_view_register_Click(object sender, EventArgs e)
        {
            view_register a = new view_register();
            a.Show();
            this.Hide();
        }

        private void btn_view_student_Click(object sender, EventArgs e)
        {
            view_student a = new view_student();
            a.Show();
            this.Hide();
        }

        private void btn_view_teacher_Click(object sender, EventArgs e)
        {
            view_teacher a = new view_teacher();
            a.Show();
            this.Hide();
        }

        private void btn_view_student_class_Click(object sender, EventArgs e)
        {
            view_student_class a = new view_student_class();
            a.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            this.Close();
            frm_login a = new frm_login();
            a.Show();
        }
    }
}
