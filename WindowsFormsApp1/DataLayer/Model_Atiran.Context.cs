﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cust_act> cust_act { get; set; }
        public virtual DbSet<CUSTOMERS> CUSTOMERS { get; set; }
        public virtual DbSet<sys_cus> sys_cus { get; set; }
        public virtual DbSet<TellBook> TellBook { get; set; }
        public virtual DbSet<visitors> visitors { get; set; }
        public virtual DbSet<custgroup> custgroup { get; set; }
    
        public virtual int USP_alireza_insert_Customer_test(string code, string special, string mONAME, Nullable<int> group_rdf, Nullable<int> vis_rdf, string addre, string tell1, Nullable<decimal> cred, Nullable<int> check_eteb, Nullable<int> just_naghdi, Nullable<int> maxManFactor, string sharh)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var specialParameter = special != null ?
                new ObjectParameter("special", special) :
                new ObjectParameter("special", typeof(string));
    
            var mONAMEParameter = mONAME != null ?
                new ObjectParameter("MONAME", mONAME) :
                new ObjectParameter("MONAME", typeof(string));
    
            var group_rdfParameter = group_rdf.HasValue ?
                new ObjectParameter("group_rdf", group_rdf) :
                new ObjectParameter("group_rdf", typeof(int));
    
            var vis_rdfParameter = vis_rdf.HasValue ?
                new ObjectParameter("vis_rdf", vis_rdf) :
                new ObjectParameter("vis_rdf", typeof(int));
    
            var addreParameter = addre != null ?
                new ObjectParameter("addre", addre) :
                new ObjectParameter("addre", typeof(string));
    
            var tell1Parameter = tell1 != null ?
                new ObjectParameter("tell1", tell1) :
                new ObjectParameter("tell1", typeof(string));
    
            var credParameter = cred.HasValue ?
                new ObjectParameter("cred", cred) :
                new ObjectParameter("cred", typeof(decimal));
    
            var check_etebParameter = check_eteb.HasValue ?
                new ObjectParameter("check_eteb", check_eteb) :
                new ObjectParameter("check_eteb", typeof(int));
    
            var just_naghdiParameter = just_naghdi.HasValue ?
                new ObjectParameter("just_naghdi", just_naghdi) :
                new ObjectParameter("just_naghdi", typeof(int));
    
            var maxManFactorParameter = maxManFactor.HasValue ?
                new ObjectParameter("MaxManFactor", maxManFactor) :
                new ObjectParameter("MaxManFactor", typeof(int));
    
            var sharhParameter = sharh != null ?
                new ObjectParameter("sharh", sharh) :
                new ObjectParameter("sharh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_alireza_insert_Customer_test", codeParameter, specialParameter, mONAMEParameter, group_rdfParameter, vis_rdfParameter, addreParameter, tell1Parameter, credParameter, check_etebParameter, just_naghdiParameter, maxManFactorParameter, sharhParameter);
        }
    }
}