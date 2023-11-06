using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUANLYBANHANG.App_Code
{
    public class CART
    {
        Dictionary<String, ITEM> listcarts;
        public Dictionary<String, ITEM> LISTCARTS
        {
            get { return this.listcarts; }
        }

        public CART()
        {
            this.listcarts = new Dictionary<string, ITEM>();
        }

        public void addCart(String masanpham, String tensanpham, String hinhanh, int soluong, double dongia)
        {
            ITEM item = new ITEM(masanpham, tensanpham, dongia, soluong, hinhanh);
            if (listcarts.ContainsKey(item.MASANPHAM))
                listcarts[item.MASANPHAM].SOLUONG += item.SOLUONG;
            else
                listcarts.Add(item.MASANPHAM, item);
        }

        public void removeCart(String masanpham)
        {
            listcarts.Remove(masanpham);
        }

        public double totalBill()
        {
            double total = 0;
            foreach(ITEM item in listcarts.Values)
            {
                total += item.THANHTIEN;
            }
            return total;
        }
    }
}