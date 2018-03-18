using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class SinhVien
    {
        private string mssv;
        private string hoten;
        private string gioitinh;
        private DateTime date;
        private string lop;
        private string nganhhoc;
        public string Mssv
        {
            get
            {
                return mssv;
            }

            set
            {
                mssv = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Lop
        {
            get
            {
                return lop;
            }

            set
            {
                lop = value;
            }
        }

        public string Nganhhoc
        {
            get
            {
                return nganhhoc;
            }

            set
            {
                nganhhoc = value;
            }
        }
    }
}
