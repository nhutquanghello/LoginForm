using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_username.Focus(); //Đưa con trỏ hiển thị ngay textbox username
            txt_password.Focus(); //Đưa con trỏ hiển thị ngay textbox password
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap()
        {
            if (txt_username.Text.Length == 0 && txt_password.Text.Length == 0)
                MessageBox.Show("Mời bạn đăng nhập!!!");
            else
                if (this.txt_username.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập Username!!!");
            else
                if (this.txt_password.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập Password!!!");
            else
                if (this.txt_username.Text == "nhutquang" && this.txt_password.Text == "123456")
                MessageBox.Show("Đăng nhập thành công");
            else
                MessageBox.Show("Mật khẩu của bạn không đúng");
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //Tạo trang thứ 2 để làm gì đó...
            Form2 fm = new Form2();
            if (this.txt_username.Text == "nhutquang" && this.txt_password.Text == "123456")
            {
                fm.Show();
            }
            dangnhap();
        }
    }
}
