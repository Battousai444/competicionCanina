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
    public class clsRaza
    {
       
            #region Constructor
            public clsRaza()
            {

            }
            #endregion
            #region Propiedades/Atributos
            public Int32 Codigo { get; set; }
            public string Raza { get; set; }

        //Agregar el combobox (DropDownList) del combo países.
        //Se necesita agregar la referencia: System.Web. Esta librería está en Ensamblados, y se agrega como una referencia
        //que uno construyó. Se agrega el using: System.Web.UI.WebControls;
            public DropDownList cboRaza { get; set; }
        
             private string SQL;
            public string Error { get; private set; }
            #endregion
            #region Metodos
            public bool Insertar()
            {
                Error = "NO se ha implementado el método";
                return false;
            }
            public bool Actualizar()
            {
                Error = "NO se ha implementado el método";
                return false;
            }
            public bool Eliminar()
            {
                Error = "NO se ha implementado el método";
                return false;
            }
            public bool Consultar()
            {
                Error = "NO se ha implementado el método";
                return false;
            }
            public bool LlenarCombo()
            {
                SQL =  "select          codigo as ColumnaValor, raza AS ColumnaTexto "+
                        "from           tblRaza " +
                        "order by       Raza; ";
            //Se crea el objeto combo
            clsCombos oCombo = new clsCombos();
                //Se pasa el SQL
                oCombo.SQL = SQL;
                //Se pasa el combo vacío
                oCombo.cboGenericoWeb = cboRaza;
                oCombo.ColumnaTexto = "ColumnaTexto";
                oCombo.ColumnaValor = "ColumnaValor";

                if (oCombo.LlenarComboWeb())
                {
                    //Capturo el combo lleno
                    cboRaza = oCombo.cboGenericoWeb;
                    return true;
                }
                else
                {
                    Error = oCombo.Error;
                    return false;
                }
            }
            #endregion
        
    }
}
