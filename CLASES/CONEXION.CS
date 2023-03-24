using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASEDEDATOSPC2.CLASES
{
    public class CONEXION
    {
        public static string conectar()
        {
            string con = @"DATA SOURCE=DESKTOP-54N9T88\SQLEXPRESS;INITIAL CATALOG=VENTAS;INTEGRATED SECURITY=TRUE";

            return con;
        }
    }
}
