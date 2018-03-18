using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLySinhVien
{
    public partial class fmSearch : Form
    {
        public static string patch = "../../SinhVien.xml";
        public fmSearch()
        {
            InitializeComponent();
        }

        private void fmSearch_Load(object sender, EventArgs e)
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
                foreach (DataRow dr in dt.Rows)
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

        XmlElement root;
        private void TimKiem(SinhVien TimSV, ListView lvSV)
        {
            lvSV.Items.Clear();
            XmlNode SVCanTim = root.SelectSingleNode("SINHVIEN[MSSV='"+TimSV.Mssv+"']");
            if(SVCanTim != null)
            {
                lvSV.Items.Clear();
                DataSet ds = new DataSet();
                ds.ReadXml(patch);
                DataTable dt = new DataTable();
                dt = ds.Tables["SINHVIEN"];
                int i = 0;
                foreach (DataRow dr in dt.Rows)
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
        }

        SinhVien sinhvien = new SinhVien();
        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            if(txtSearchSV.Text.Trim() != "")
            {
                sinhvien.Mssv = txtSearchSV.Text.ToLower();
                TimKiem(sinhvien, lvSV);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
