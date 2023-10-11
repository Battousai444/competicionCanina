using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clases.examenes;
using libComunes.CapaDatos;
using libComunes.CapaObjetos;

namespace Examen4TorneoWeb.examen4
{
    public partial class examen4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarComboRaza();
                LlenarGridTorneo();
            }
        }
        private void LlenarComboRaza()
        {
            clsRaza oRaza = new clsRaza();
            oRaza.cboRaza = cboRaza;
            if (oRaza.LlenarCombo() == false)
            {
                lblError.Text = oRaza.Error;
            }
        }
        private void LlenarGridTorneo()
        {
            clsTorneo oTorneo = new clsTorneo();
            oTorneo.grdTorneo = grdUrgencias;
            if (!oTorneo.LlenarGrid())
            {
                lblError.Text = oTorneo.Error;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string Nombre, NombreDueño,  NombreTorneo, Puesto;
            DateTime FechaTorneo;
            Int32 Raza;
            

            Nombre = txtNombre.Text;
            NombreDueño = txtNombreDueño.Text;
            NombreTorneo = cboNombreTorneo.Text;
            Puesto = txtPuesto.Text;
            Raza = Convert.ToInt32(cboRaza.SelectedValue);
            FechaTorneo = Convert.ToDateTime(txtFechaTorneo.Text);

            clsTorneo oTorneo = new clsTorneo();

            oTorneo.Nombre = Nombre;
            oTorneo.NombreDueño = NombreDueño;
            oTorneo.NombreTorneo = NombreTorneo;
            oTorneo.PuestoTorneo = Puesto;
            oTorneo.codigoRaza = Raza;
            oTorneo.FechaTorneo = FechaTorneo;

            if (oTorneo.Insertar())
            {
                lblError.Text = "";
                LlenarGridTorneo();
            }
            else
            {
                lblError.Text = oTorneo.Error;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string Nombre, NombreDueño, NombreTorneo, Puesto;
            DateTime FechaTorneo;
            Int32 Raza, Codigo;

            Codigo = Convert.ToInt32(lblCodigo.Text);
            Nombre = txtNombre.Text;
            NombreDueño = txtNombreDueño.Text;
            NombreTorneo = cboNombreTorneo.Text;
            Puesto = txtPuesto.Text;
            Raza = Convert.ToInt32(cboRaza.SelectedValue);
            FechaTorneo = Convert.ToDateTime(txtFechaTorneo.Text);

            clsTorneo oTorneo = new clsTorneo();

            oTorneo.Codigo = Codigo;
            oTorneo.Nombre = Nombre;
            oTorneo.NombreDueño = NombreDueño;
            oTorneo.NombreTorneo = NombreTorneo;
            oTorneo.PuestoTorneo = Puesto;
            oTorneo.codigoRaza = Raza;
            oTorneo.FechaTorneo = FechaTorneo;

            if (oTorneo.Actualizar())
            {
                lblError.Text = "";
                LlenarGridTorneo();
            }
            else
            {
                lblError.Text = oTorneo.Error;
            }
        }
    

        protected void btnBorrar_Click(object sender, EventArgs e)
        {

            
            Int32  Codigo;

            Codigo = Convert.ToInt32(lblCodigo.Text);
            

            clsTorneo oTorneo = new clsTorneo();

            oTorneo.Codigo = Codigo;
           

            if (oTorneo.Eliminar())
            {
                lblError.Text = "";
                LlenarGridTorneo();
            }
            else
            {
                lblError.Text = oTorneo.Error;
            }
        }

        protected void grdUrgencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si profe use el suyo y le di al doble clic sin quere en el grid XD
            lblCodigo.Text = grdUrgencias.SelectedRow.Cells[1].Text;
            txtNombre.Text= grdUrgencias.SelectedRow.Cells[2].Text;
            txtNombreDueño.Text = grdUrgencias.SelectedRow.Cells[5].Text;
            txtFechaTorneo.Text = grdUrgencias.SelectedRow.Cells[4].Text;
            txtPuesto.Text= grdUrgencias.SelectedRow.Cells[6].Text;
            cboNombreTorneo.SelectedValue = grdUrgencias.SelectedRow.Cells[3].Text;
            String valor = grdUrgencias.SelectedRow.Cells[7].Text;
            string SQL;
            string valoint="0";
            int VAL = 0;
            
            SQL = "SELECT Codigo FROM tblRaza " +
                  "WHERE Raza = @rValor";

            clsConexion oConexion = new clsConexion();
            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@rvalor", valor);
            if (oConexion.Consultar())
            {
                if (oConexion.Reader.HasRows)
                {
                    //leer
                    oConexion.Reader.Read();
                    VAL =  oConexion.Reader.GetInt32(0); 
                }
                
            }
            else
            {
                lblError.Text = "no dunciono";
               
            }
            valoint = VAL.ToString();
             cboRaza.SelectedValue = valoint;



        }
    }
}