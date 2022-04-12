using GrupoFamiliarPoli.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupoFamiliarPoli.Models.Response
{
    public class ProccessResponse
    {
        public pacientes paciente { get; set; }
        public List<grupo_familiar> grupo_familiar { get; set; }
    }
}