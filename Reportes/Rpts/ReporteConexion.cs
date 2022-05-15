using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportes.Rpts
{
    public class ReporteConexion
    {
       public static CrystalDecisions.Shared.ConnectionInfo GetConnection()
        {
            CrystalDecisions.Shared.ConnectionInfo infocon = new CrystalDecisions.Shared.ConnectionInfo();

            infocon.ServerName = @"DESKTOP-7IIODCS\SQLEXPRESS";
            infocon.DatabaseName = "RESTAURANTE";
            infocon.IntegratedSecurity = true;

            return infocon;
        }
    }
}