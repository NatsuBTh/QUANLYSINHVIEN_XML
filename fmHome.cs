using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLySinhVien
{
    public partial class fmHome : Form
    {

        public static string patch = "../../SinhVien.xml";
        public fmHome()
        {
            InitializeComponent();
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            fmLogin fmLogin = new fmLogin();
            this.Hide();
            fmLogin.ShowDialog();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra
            if (char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsNumber(e.KeyChar) || //chữ số
                char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập ký tự đặc biệt, chữ số và dấu chấm");
            }
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra
            if (char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập ký tự đặc biệt, khoảng cách và dấu chấm");
            }
        }

        private void txtClass_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            //kiểm tra
            if (char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập ký tự đặc biệt, khoảng cách và dấu chấm");
            }
        }

        private void fmHome_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                lvSV.Items.Clear();
                DataSet ds = new DataSet();
                ds.ReadXml(patch);
                DataTable dt = new DataTable();
                dt = ds.Tables["SINHVIEN"];
                int i = 0;
                foreach(DataRow dr in dt.Rows)
                {
                    lvSV.Items.Add(dr["ID"].ToString());
                    lvSV.Items[i].SubItems.Add(dr["MSSV"].ToString());
                    lvSV.Items[i].SubItems.Add(dr["NAME"].ToString());
                    lvSV.Items[i].SubItems.Add(dr["SEX"].ToString());
                    lvSV.Items[i].SubItems.Add(dr["DATE"].ToString());
                    lvSV.Items[i].SubItems.Add(dr["CLASS"].ToString());
                    lvSV.Items[i].SubItems.Add(dr["INDUSTRY"].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            long id = long.Parse(day + month + year + hour + minute + second);
            try
            {
                XDocument testXML = XDocument.Load(patch);
                XElement newSV = new XElement("SINHVIEN",
                    new XElement("MSSV", txtMSSV.Text),
                    new XElement("NAME", txtName.Text),
                    new XElement("SEX", cbSex.Text),
                    new XElement("DATE", dtpkDate.Text),
                    new XElement("CLASS", txtClass.Text),
                    new XElement("INDUSTRY", cbIndustry.Text)
                    );
                var LastSV = testXML.Descendants("SINHVIEN").Last();
                long newID = Convert.ToInt64(LastSV.Attribute("ID").Value);
                newSV.SetAttributeValue("ID", id);
                testXML.Element("SINH_VIEN").Add(newSV);
                testXML.Save(patch);
                MessageBox.Show("Thêm thành công", "Thông báo");
                fmHome_Load(sender, e);
                SetNull();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument testXML = XDocument.Load(patch);
                XElement EditSV = testXML.Descendants("SINHVIEN").Where(c => c.Attribute("ID").Value.Equals(lbID.Text)).FirstOrDefault();
                EditSV.Element("MSSV").Value = txtMSSV.Text;
                EditSV.Element("NAME").Value = txtName.Text;
                EditSV.Element("SEX").Value = cbSex.Text;
                EditSV.Element("DATE").Value = dtpkDate.Text;
                EditSV.Element("CLASS").Value = txtClass.Text;
                EditSV.Element("INDUSTRY").Value = cbIndustry.Text;
                testXML.Save(patch);
                MessageBox.Show("Sửa thành công", "Thông báo");
                fmHome_Load(sender, e);
                SetNull();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument testXML = XDocument.Load(patch);
                XElement EditSV = testXML.Descendants("SINHVIEN").Where(c => c.Attribute("ID").Value.Equals(lbID.Text)).FirstOrDefault();
                EditSV.Remove();                
                testXML.Save(patch);
                MessageBox.Show("Xóa thành công", "Thông báo");
                fmHome_Load(sender, e);
                SetNull();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SetNull()
        {
            txtMSSV.Text = "";
            txtName.Text = "";
            cbSex.SelectedItem = null;
            dtpkDate.Text = DateTime.Now.ToString();
            txtClass.Text = "";
            cbIndustry.SelectedItem = null;
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvSV.SelectedItems)
            {
                lbID.Text = item.SubItems[0].Text;
                txtMSSV.Text = item.SubItems[1].Text;
                txtName.Text = item.SubItems[2].Text;
                cbSex.Text = item.SubItems[3].Text;
                dtpkDate.Text = item.SubItems[4].Text;
                txtClass.Text = item.SubItems[5].Text;
                cbIndustry.Text = item.SubItems[6].Text;
            }
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            fmSearch fmSearch = new fmSearch();
            fmSearch.ShowDialog();
        }
    }
}
