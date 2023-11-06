using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using QUANLYBANHANG;

namespace QUANLYBANHANG_ONLINE.ADMIN.PROCESSDATA
{
    public class QUANLYSANPHAM_PROCESSDATA
    {
        private dbQUANLYBANHANGEntities db;
        public QUANLYSANPHAM_PROCESSDATA()
        {
            db = new dbQUANLYBANHANGEntities();
        }
        public List<tbDANHMUC> getTableDanhmuc()
        {
            try
            {
                return db.tbDANHMUC.ToList<tbDANHMUC>();
            }
            catch (SqlException ex)
            {
            }
            return null;
        }
        public List<tbSANPHAM> getTableSanPham()
        {
            try
            {
                var tbsanpham = from tbSANPHAM in db.tbSANPHAM
                                select tbSANPHAM;
                return tbsanpham.ToList();
            }
            catch (SqlException ex)
            {
            }
            return null;
        }
        public int InsertRecord(Dictionary<String, Object> list)
        {
            int k = 0;
            try
            {

                k = db.psInsertRecordSANPHAM((String)list["@TENSANPHAM"],
               Convert.ToDecimal(list["@DONGIA"]), Convert.ToInt32(list["@SOLUONG"]), (String)list["@HINHANH"],
               (String)list["@MOTA"], Convert.ToInt32(list["@MADANHMUC"]));
                db.SaveChanges();
            }
            catch (SqlException ex)
            {

            }
            return k;

        }
        public int UpdateRecord(Dictionary<String, Object> list)
        {
            int k = 0;
            try
            {
                k = db.psUpdateRecordSANPHAM(Convert.ToInt32(list["@MASANPHAM"]),
               (String)list["@TENSANPHAM"], Convert.ToDecimal(list["@DONGIA"]), Convert.ToInt32(list["@SOLUONG"]),
               (String)list["@HINHANH"], (String)list["@MOTA"], Convert.ToInt32(list["@MADANHMUC"]));
                db.SaveChanges();

            }
            catch (SqlException ex)
            {
            }
            return k;
        }
        public int DeleteRecord(int id)
        {
            int k = 0;
            try
            {
                k = db.psDeleteRecordSANPHAM(id);
                db.SaveChanges();
            }
            catch (SqlException ex)
            {
            }
            return k;
        }
    }
}
