﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CitasSalonApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CitasModelContainer : DbContext
    {
        public CitasModelContainer()
            : base("name=CitasModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<TipoServicio> TipoServicios { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<EstadoCita> EstadoCitas { get; set; }
        public virtual DbSet<EstadoCliente> EstadoClientes { get; set; }
        public virtual DbSet<Fecha> Fechas { get; set; }
        public virtual DbSet<EstadoHorario> EstadoHorarios { get; set; }
        public virtual DbSet<Hora> Horas { get; set; }
        public virtual DbSet<DetalleFechaBloque> DetalleFechaBloques { get; set; }
    }
}
