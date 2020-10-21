using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Configuracion
    {
        //@"servidor,nombreBD,usuario,password"
        static string cadenaConexion = @" Data Source = localhost\SQLEXPRESS01; Initial Catalog = concesionarioCesde; Trusted_Connection = true ";

        public static string CadenaConexion
        {
            get { return cadenaConexion;  }
        }
    }
}
