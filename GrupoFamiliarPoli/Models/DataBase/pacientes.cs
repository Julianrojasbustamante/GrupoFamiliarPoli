//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrupoFamiliarPoli.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class pacientes
    {
        [Key, Column(Order = 0)]
        public long id_paciente { get; set; }
        public sbyte estado { get; set; }
        public string nom_paciente { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_actualizacion { get; set; }
        public int num_dni { get; set; }
    }
}
