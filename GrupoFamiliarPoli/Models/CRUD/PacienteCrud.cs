using GrupoFamiliarPoli.Models.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupoFamiliarPoli.Models.CRUD
{
    public class PacienteCrud
    {
        public List<pacientes> GetPacientes(pacientes _pacientes)
        {
            using (MySqlConnection connection = new MySqlConnection())
            {
                using (hospitalpoliEntities1 context = new hospitalpoliEntities1())
                {
                    try
                    {
                        var query = (from a in context.pacientes select a).ToList();
                        return query;
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            }
        }
    }
}