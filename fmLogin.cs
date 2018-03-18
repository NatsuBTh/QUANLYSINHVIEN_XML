using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void fmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi chương trình","Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo");
            }
            if(txtPassword.Text == "" && txtUsername.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
            }
            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thong báo");
            }
            if((txtUsername.Text == "admin" && txtPassword.Text == "123456789"))
            {
                fmHome fmHome = new fmHome();

                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                fmHome.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == "" && txtPassword.Text != "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo");
                }
                if (txtPassword.Text == "" && txtUsername.Text != "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
                }
                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thong báo");
                }
                if ((txtUsername.Text == "admin" && txtPassword.Text == "123456789"))
                {
                    fmHome fmHome = new fmHome();

                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    fmHome.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
        }
    }
}
