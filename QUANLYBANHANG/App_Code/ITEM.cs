using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUANLYBANHANG.App_Code
{
    public class ITEM
    {
        private String masanpham;
        private String tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;
        private double thanhtien;

        public ITEM(string masanpham, string tensanpham, double dongia, int soluong, string hinhanh)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.dongia = dongia;
            this.soluong = soluong;
            this.hinhanh = hinhanh;
        }

        public String MASANPHAM
        {
            set { this.masanpham = value; }
            get { return this.masanpham; }
        }
        public String HINHANH
        {
            set { this.hinhanh = value; }
            get { return this.hinhanh; }
        }

        public String TENSANPHAM
        {
            set { this.tensanpham = value; }
            get { return this.tensanpham; }
        }

        public double DONGIA
        {
            set { this.dongia = value; }
            get { return this.dongia; }
        }

        public int SOLUONG
        {
            set { this.soluong = value; }
            get { return this.soluong; }
        }

        public ITEM()
        {
        }

        public double THANHTIEN
        {
           get { return this.soluong * this.dongia; }
        }
    }
}