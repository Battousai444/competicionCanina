using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libComunes.CapaDatos;
using libComunes.CapaObjetos;
using System.Web.UI.WebControls;

namespace clases.examenes
{
   public class clsTorneo
    {
        #region Constructor
        public clsTorneo()
        {
        
        }
        #endregion
        #region Propiedades/Atributos
        public Int32 Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreTorneo { get; set; }
      
        public DateTime FechaTorneo { get; set; }
        public string NombreDueño { get; set; }
        public string PuestoTorneo { get; set; }
        public Int32 codigoRaza { get; set; }

        public GridView grdTorneo { get; set; }
       
        private string SQL;
        public string Error { get; private set; }
        #endregion
        #region Metodos
        public bool LlenarGrid()
        {
            //Se crea la instrucción sql
            SQL = "SELECT        dbo.tblTorneo.Codigo AS [CODIGO TONEO], dbo.tblTorneo.Nombre AS [NOMBRE DE LA MASCOTA], " +
                                "dbo.tblTorneo.NombreTorneo AS [NOMBRE TORNEO], dbo.tblTorneo.FechaTorneo AS[FECHA DEL TORNEO], " +
                                "dbo.tblTorneo.NombreDueño AS DUEÑO, dbo.tblTorneo.PuestoTorneo AS PUESTO, dbo.tblRaza.Raza AS RAZA " +
                "FROM            dbo.tblRaza INNER JOIN " +
                                "dbo.tblTorneo ON dbo.tblRaza.Codigo = dbo.tblTorneo.intCodigoRaza  " +
                "ORDER BY       [NOMBRE TORNEO], PUESTO; ";

            //Se crea el objeto grid
            clsGrid oGrid = new clsGrid();
            //Paso el sql y el grid vacío
            oGrid.SQL = SQL;
            oGrid.grdGenerico = grdTorneo;
            //Invocar el llenado del grid
            if (oGrid.LlenarGridWeb())
            {
                //lee el grid lleno
                grdTorneo = oGrid.grdGenerico;
                return true;
            }
            else
            {
                Error = oGrid.Error;
                return false;
            }
        }
        public bool Insertar()
        {
            SQL = "INSERT INTO tblTorneo (Nombre, NombreTorneo, FechaTorneo, NombreDueño, PuestoTorneo, intCodigoRaza) " +
                  "VALUES (@prNombre, @prNombreTorneo, @prFechaTorneo, @prNombreDueño, @prPuestoTorneo, @printCodigoRaza)";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@prNombre", Nombre);
            oConexion.AgregarParametro("@prNombreTorneo", NombreTorneo);
            oConexion.AgregarParametro("@prFechaTorneo", FechaTorneo);
            oConexion.AgregarParametro("@prNombreDueño", NombreDueño);
            oConexion.AgregarParametro("@prPuestoTorneo", PuestoTorneo);
            oConexion.AgregarParametro("@printCodigoRaza", codigoRaza);

            if (oConexion.EjecutarSentencia())
            {
                return true;
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }
        public bool Actualizar()
        {
            SQL = "UPDATE       tblTorneo " +
                  "SET          Nombre = @prNombre, " +
                               "NombreTorneo = @prNombreTorneo, " +
                               "FechaTorneo = @prFechaTorneo, " +
                               "NombreDueño = @prNombreDueño, " +
                               "PuestoTorneo = @prPuestoTorneo, " +
                               "intCodigoRaza = @printCodigoRaza " +
                  "WHERE        Codigo = @prCodigo";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@prCodigo", Codigo);
            oConexion.AgregarParametro("@prNombre", Nombre);
            oConexion.AgregarParametro("@prNombreTorneo", NombreTorneo);
            oConexion.AgregarParametro("@prFechaTorneo", FechaTorneo);
            oConexion.AgregarParametro("@prNombreDueño", NombreDueño);
            oConexion.AgregarParametro("@prPuestoTorneo", PuestoTorneo);
            oConexion.AgregarParametro("@printCodigoRaza", codigoRaza);

            if (oConexion.EjecutarSentencia())
            {
                return true;
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }
        public bool Eliminar()
        {
            SQL = "DELETE FROM  tblTorneo " +
                  "WHERE        Codigo = @prCodigo";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@prCodigo", Codigo);

            if (oConexion.EjecutarSentencia())
            {
                return true;
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }
        #endregion
    }
}
    

