using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApplication1.Datos
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;
        public Conexion()
        {
            //ESTO ES PARA PODER OBETENER LA CADENA DE CONEXION QUE ESTA EN EL ARCHIVO appsettings
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string getCadenaSQL()
        {
            return cadenaSQL;
        }
    }
}
