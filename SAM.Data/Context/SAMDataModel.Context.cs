﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using SAM.Entities;

namespace SAM.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SAMEntities : DbContext
    {
        public SAMEntities()
            : base("name=SAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<clienteTipo> clienteTipo { get; set; }
        public virtual DbSet<ClienteVehiculo> ClienteVehiculo { get; set; }
        public virtual DbSet<Externo> Externo { get; set; }
        public virtual DbSet<ManoObra> ManoObra { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<MedioPago> MedioPago { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<Parte> Parte { get; set; }
        public virtual DbSet<Proceso> Proceso { get; set; }
        public virtual DbSet<Sistemas> Sistemas { get; set; }
        public virtual DbSet<Taller> Taller { get; set; }
        public virtual DbSet<TallerParametro> TallerParametro { get; set; }
        public virtual DbSet<TallerSucursal> TallerSucursal { get; set; }
        public virtual DbSet<TallerSucursalEstacion> TallerSucursalEstacion { get; set; }
        public virtual DbSet<TipoFactura> TipoFactura { get; set; }
        public virtual DbSet<Trabajo> Trabajo { get; set; }
        public virtual DbSet<TrabajoExterno> TrabajoExterno { get; set; }
        public virtual DbSet<TrabajoManoObra> TrabajoManoObra { get; set; }
        public virtual DbSet<TrabajoPago> TrabajoPago { get; set; }
        public virtual DbSet<TrabajoParte> TrabajoParte { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
    }
}