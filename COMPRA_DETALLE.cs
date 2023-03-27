using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BASEDEDATOSPC2.CLASES;

namespace BASEDEDATOSPC2
{
    public partial class COMPRA_DETALLE : Form
    {
        public COMPRA_DETALLE()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            TXTFOLIO.Clear();
            TXTSERIE.Clear();
            TXTISTIPODOCUMENTO.Clear();
            CBPRODUCTOS.SelectedIndex = 1;
            TXTCANTIDAD.Clear();
            TXTIMPORTE.Clear();
            TXTIVA.Clear();
            TXTIDUBICACION.Clear();
        }

        private void llenarproductos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CONEXION.conectar()))
            {
                string query = "SELECT PR_ID, PR_NOMBRE FROM PRODUCTOS";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            CBPRODUCTOS.DisplayMember = "PR_NOMBRE";
            CBPRODUCTOS.ValueMember = "PR_ID";
            CBPRODUCTOS.DataSource = dt;
        }

        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRAS_DETALLES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@CD_FOLIO", TXTFOLIO.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    if (R["CD_FOLIO"].ToString() != "")
                    {
                        TXTFOLIO.Text = R["CD_FOLIO"].ToString();
                        TXTSERIE.Text = R["CD_SERIE"].ToString();
                        TXTISTIPODOCUMENTO.Text = R["CD_ID_TIPODOCTO"].ToString();
                        CBPRODUCTOS.SelectedValue = R["CD_ID_PRODUCTO"].ToString();
                        TXTCANTIDAD.Text = R["CD_CANTIDAD"].ToString();
                        TXTIMPORTE.Text = R["CD_IMPORTE"].ToString();
                        TXTIVA.Text = R["CD_IVA"].ToString();
                        TXTIDUBICACION.Text = R["CD_UBICACION"].ToString();

                    }
                    else
                    {
                        limpiar();
                        MessageBox.Show("No se encontraron datos");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.cOMPRAS_DETALLETableAdapter1.Fill(this.dsCOMPRASDETALLE.COMPRAS_DETALLE);
            }
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRAS_DETALLES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CD_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@CD_SERIE", TXTSERIE.Text);
            cmd.Parameters.AddWithValue("@CD_ID_TIPODOCTO", TXTISTIPODOCUMENTO.Text);
            cmd.Parameters.AddWithValue("@CD_ID_PRODUCTO", CBPRODUCTOS.SelectedValue);
            cmd.Parameters.AddWithValue("@CD_CANTIDAD", TXTCANTIDAD.Text);
            cmd.Parameters.AddWithValue("@CD_IMPORTE", TXTIMPORTE.Text);
            cmd.Parameters.AddWithValue("@CD_IVA", TXTIVA.Text);
            cmd.Parameters.AddWithValue("@CD_UBICACION", TXTIDUBICACION.Text);

            MessageBox.Show("Sus datos se guardaron correctamente");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.cOMPRAS_DETALLETableAdapter1.Fill(this.dsCOMPRASDETALLE.COMPRAS_DETALLE);
                limpiar();
            }
        }

        private void eliminar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRAS_DETALLES";
            cmd.Parameters.AddWithValue("@Op", 3);
            cmd.Parameters.AddWithValue("@CD_FOLIO", TXTFOLIO.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sus datos se eliminaron correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.cOMPRAS_DETALLETableAdapter1.Fill(this.dsCOMPRASDETALLE.COMPRAS_DETALLE);
                limpiar();
            }

        }

        private void COMPRA_DETALLE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCOMPRASDETALLE.COMPRAS_DETALLE' Puede moverla o quitarla según sea necesario.
            this.cOMPRAS_DETALLETableAdapter1.Fill(this.dsCOMPRASDETALLE.COMPRAS_DETALLE);
            llenarproductos();

        }

        private void TXTFOLIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDPRODUCTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDPRODUCTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIMPORTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDUBICACION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
