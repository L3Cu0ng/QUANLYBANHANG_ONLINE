﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYBANHANG
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbQUANLYBANHANGEntities : DbContext
    {
        public dbQUANLYBANHANGEntities()
            : base("name=dbQUANLYBANHANGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<APPLICATIONS> APPLICATIONS { get; set; }
        public virtual DbSet<GENDER> GENDER { get; set; }
        public virtual DbSet<GENDER_TYPE> GENDER_TYPE { get; set; }
        public virtual DbSet<GROUP_USER> GROUP_USER { get; set; }
        public virtual DbSet<GROUP_USER_RELATIONSHIP_USER> GROUP_USER_RELATIONSHIP_USER { get; set; }
        public virtual DbSet<MENU_FORM> MENU_FORM { get; set; }
        public virtual DbSet<PARTY> PARTY { get; set; }
        public virtual DbSet<PERSON> PERSON { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbCHITIETHOADON> tbCHITIETHOADON { get; set; }
        public virtual DbSet<tbDANHMUC> tbDANHMUC { get; set; }
        public virtual DbSet<tbHOADON> tbHOADON { get; set; }
        public virtual DbSet<tbKHANHHANG> tbKHANHHANG { get; set; }
        public virtual DbSet<tbSANPHAM> tbSANPHAM { get; set; }
    
        public virtual int psDeleteRecordSANPHAM(Nullable<int> mASANPHAM)
        {
            var mASANPHAMParameter = mASANPHAM.HasValue ?
                new ObjectParameter("MASANPHAM", mASANPHAM) :
                new ObjectParameter("MASANPHAM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("psDeleteRecordSANPHAM", mASANPHAMParameter);
        }
    
        public virtual ObjectResult<psGetTableDANHMUC_Result> psGetTableDANHMUC(Nullable<int> mADANHMUC)
        {
            var mADANHMUCParameter = mADANHMUC.HasValue ?
                new ObjectParameter("MADANHMUC", mADANHMUC) :
                new ObjectParameter("MADANHMUC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<psGetTableDANHMUC_Result>("psGetTableDANHMUC", mADANHMUCParameter);
        }
    
        public virtual ObjectResult<psGetTableLOGIN_Result> psGetTableLOGIN(string uSERNAME, string pASSWORD)
        {
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<psGetTableLOGIN_Result>("psGetTableLOGIN", uSERNAMEParameter, pASSWORDParameter);
        }
    
        public virtual ObjectResult<psGetTableSANPHAM_Result> psGetTableSANPHAM(Nullable<int> mASANPHAM)
        {
            var mASANPHAMParameter = mASANPHAM.HasValue ?
                new ObjectParameter("MASANPHAM", mASANPHAM) :
                new ObjectParameter("MASANPHAM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<psGetTableSANPHAM_Result>("psGetTableSANPHAM", mASANPHAMParameter);
        }
    
        public virtual int psInsertRecordSANPHAM(string tENSANPHAM, Nullable<decimal> dONGIA, Nullable<int> sOLUONG, string hINHANH, string mOTA, Nullable<int> mADANHMUC)
        {
            var tENSANPHAMParameter = tENSANPHAM != null ?
                new ObjectParameter("TENSANPHAM", tENSANPHAM) :
                new ObjectParameter("TENSANPHAM", typeof(string));
    
            var dONGIAParameter = dONGIA.HasValue ?
                new ObjectParameter("DONGIA", dONGIA) :
                new ObjectParameter("DONGIA", typeof(decimal));
    
            var sOLUONGParameter = sOLUONG.HasValue ?
                new ObjectParameter("SOLUONG", sOLUONG) :
                new ObjectParameter("SOLUONG", typeof(int));
    
            var hINHANHParameter = hINHANH != null ?
                new ObjectParameter("HINHANH", hINHANH) :
                new ObjectParameter("HINHANH", typeof(string));
    
            var mOTAParameter = mOTA != null ?
                new ObjectParameter("MOTA", mOTA) :
                new ObjectParameter("MOTA", typeof(string));
    
            var mADANHMUCParameter = mADANHMUC.HasValue ?
                new ObjectParameter("MADANHMUC", mADANHMUC) :
                new ObjectParameter("MADANHMUC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("psInsertRecordSANPHAM", tENSANPHAMParameter, dONGIAParameter, sOLUONGParameter, hINHANHParameter, mOTAParameter, mADANHMUCParameter);
        }
    
        public virtual int psUpdateRecordSANPHAM(Nullable<int> mASANPHAM, string tENSANPHAM, Nullable<decimal> dONGIA, Nullable<int> sOLUONG, string hINHANH, string mOTA, Nullable<int> mADANHMUC)
        {
            var mASANPHAMParameter = mASANPHAM.HasValue ?
                new ObjectParameter("MASANPHAM", mASANPHAM) :
                new ObjectParameter("MASANPHAM", typeof(int));
    
            var tENSANPHAMParameter = tENSANPHAM != null ?
                new ObjectParameter("TENSANPHAM", tENSANPHAM) :
                new ObjectParameter("TENSANPHAM", typeof(string));
    
            var dONGIAParameter = dONGIA.HasValue ?
                new ObjectParameter("DONGIA", dONGIA) :
                new ObjectParameter("DONGIA", typeof(decimal));
    
            var sOLUONGParameter = sOLUONG.HasValue ?
                new ObjectParameter("SOLUONG", sOLUONG) :
                new ObjectParameter("SOLUONG", typeof(int));
    
            var hINHANHParameter = hINHANH != null ?
                new ObjectParameter("HINHANH", hINHANH) :
                new ObjectParameter("HINHANH", typeof(string));
    
            var mOTAParameter = mOTA != null ?
                new ObjectParameter("MOTA", mOTA) :
                new ObjectParameter("MOTA", typeof(string));
    
            var mADANHMUCParameter = mADANHMUC.HasValue ?
                new ObjectParameter("MADANHMUC", mADANHMUC) :
                new ObjectParameter("MADANHMUC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("psUpdateRecordSANPHAM", mASANPHAMParameter, tENSANPHAMParameter, dONGIAParameter, sOLUONGParameter, hINHANHParameter, mOTAParameter, mADANHMUCParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
