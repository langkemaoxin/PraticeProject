﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTest_001
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class I200_SubbranchEntities : DbContext
    {
        public I200_SubbranchEntities()
            : base("name=I200_SubbranchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_Subbranch_Account> T_Subbranch_Account { get; set; }
        public virtual DbSet<T_Subbranch_AccountMenu> T_Subbranch_AccountMenu { get; set; }
        public virtual DbSet<T_Subbranch_Allocation> T_Subbranch_Allocation { get; set; }
        public virtual DbSet<T_Subbranch_AllocationItem> T_Subbranch_AllocationItem { get; set; }
        public virtual DbSet<T_Subbranch_Area> T_Subbranch_Area { get; set; }
        public virtual DbSet<T_Subbranch_EnterpriseInfo> T_Subbranch_EnterpriseInfo { get; set; }
        public virtual DbSet<T_Subbranch_EnterpriseProduct> T_Subbranch_EnterpriseProduct { get; set; }
        public virtual DbSet<T_Subbranch_Export_Log> T_Subbranch_Export_Log { get; set; }
        public virtual DbSet<T_Subbranch_Function> T_Subbranch_Function { get; set; }
        public virtual DbSet<T_Subbranch_GoodPic> T_Subbranch_GoodPic { get; set; }
        public virtual DbSet<T_Subbranch_Goods_Attribute> T_Subbranch_Goods_Attribute { get; set; }
        public virtual DbSet<T_Subbranch_Goods_AttributeVal> T_Subbranch_Goods_AttributeVal { get; set; }
        public virtual DbSet<T_Subbranch_Goods_Relation> T_Subbranch_Goods_Relation { get; set; }
        public virtual DbSet<T_Subbranch_Goods_Sku> T_Subbranch_Goods_Sku { get; set; }
        public virtual DbSet<T_Subbranch_GoodsCategory> T_Subbranch_GoodsCategory { get; set; }
        public virtual DbSet<T_Subbranch_GoodsClass> T_Subbranch_GoodsClass { get; set; }
        public virtual DbSet<T_Subbranch_GoodsInfo> T_Subbranch_GoodsInfo { get; set; }
        public virtual DbSet<T_Subbranch_GoodsStock> T_Subbranch_GoodsStock { get; set; }
        public virtual DbSet<T_Subbranch_GoodsStock_ChangeEnum> T_Subbranch_GoodsStock_ChangeEnum { get; set; }
        public virtual DbSet<T_Subbranch_GoodsStock_ChangeLog> T_Subbranch_GoodsStock_ChangeLog { get; set; }
        public virtual DbSet<T_Subbranch_Login_Log> T_Subbranch_Login_Log { get; set; }
        public virtual DbSet<T_Subbranch_MainGoods> T_Subbranch_MainGoods { get; set; }
        public virtual DbSet<T_Subbranch_MainStockLog> T_Subbranch_MainStockLog { get; set; }
        public virtual DbSet<T_Subbranch_MemberInfo> T_Subbranch_MemberInfo { get; set; }
        public virtual DbSet<T_Subbranch_Menu> T_Subbranch_Menu { get; set; }
        public virtual DbSet<T_Subbranch_OnlineMallOrder> T_Subbranch_OnlineMallOrder { get; set; }
        public virtual DbSet<T_Subbranch_OnlineMallOrderDetail> T_Subbranch_OnlineMallOrderDetail { get; set; }
        public virtual DbSet<T_Subbranch_OnlineMallOrderDetailTemp> T_Subbranch_OnlineMallOrderDetailTemp { get; set; }
        public virtual DbSet<T_Subbranch_OnlineMallOrderReturn> T_Subbranch_OnlineMallOrderReturn { get; set; }
        public virtual DbSet<T_Subbranch_OnlineMallProduct> T_Subbranch_OnlineMallProduct { get; set; }
        public virtual DbSet<T_Subbranch_Qouta_Log> T_Subbranch_Qouta_Log { get; set; }
        public virtual DbSet<T_Subbranch_Quota> T_Subbranch_Quota { get; set; }
        public virtual DbSet<T_Subbranch_Role> T_Subbranch_Role { get; set; }
        public virtual DbSet<T_Subbranch_RoleFunction> T_Subbranch_RoleFunction { get; set; }
        public virtual DbSet<T_Subbranch_SaleInfo> T_Subbranch_SaleInfo { get; set; }
        public virtual DbSet<T_Subbranch_SaleList> T_Subbranch_SaleList { get; set; }
        public virtual DbSet<T_Subbranch_Setting> T_Subbranch_Setting { get; set; }
        public virtual DbSet<T_Subbranch_Shop> T_Subbranch_Shop { get; set; }
        public virtual DbSet<T_Subbranch_ShopArea> T_Subbranch_ShopArea { get; set; }
        public virtual DbSet<T_Subbranch_TransferLog> T_Subbranch_TransferLog { get; set; }
        public virtual DbSet<T_Subbranch_ZeroOrder> T_Subbranch_ZeroOrder { get; set; }
        public virtual DbSet<T_Subbranch_AccountArea> T_Subbranch_AccountArea { get; set; }
        public virtual DbSet<T_Subbranch_AuthCode> T_Subbranch_AuthCode { get; set; }
    
        public virtual int AddQoutaByPhone(string phoneNumber, Nullable<int> addNumber, Nullable<int> addYear)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("phoneNumber", phoneNumber) :
                new ObjectParameter("phoneNumber", typeof(string));
    
            var addNumberParameter = addNumber.HasValue ?
                new ObjectParameter("AddNumber", addNumber) :
                new ObjectParameter("AddNumber", typeof(int));
    
            var addYearParameter = addYear.HasValue ?
                new ObjectParameter("AddYear", addYear) :
                new ObjectParameter("AddYear", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddQoutaByPhone", phoneNumberParameter, addNumberParameter, addYearParameter);
        }
    
        public virtual int ChangePrice(Nullable<int> busid, Nullable<decimal> price)
        {
            var busidParameter = busid.HasValue ?
                new ObjectParameter("busid", busid) :
                new ObjectParameter("busid", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangePrice", busidParameter, priceParameter);
        }
    
        public virtual int FreeProject(Nullable<int> busId)
        {
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FreeProject", busIdParameter);
        }
    
        public virtual int GetEId(string phoneNumber)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetEId", phoneNumberParameter);
        }
    
        public virtual int OpenEnterprise(string phoneNumber)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OpenEnterprise", phoneNumberParameter);
        }
    }
}
