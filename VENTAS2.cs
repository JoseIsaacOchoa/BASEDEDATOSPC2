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
    public partial class VENTAS2 : Form
    {
        public VENTAS2()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            TXTCANTIDAD.Clear();
            TXTIMPORTE.Clear();
            TXTIVA.Clear();
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
        private void llenarclientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CONEXION.conectar()))
            {
                string query = "SELECT CL_ID, CL_NOMBRE FROM CLIENTES";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            CBCLIENTES.DisplayMember = "CL_NOMBRE";
            CBCLIENTES.ValueMember = "CL_ID";
            CBCLIENTES.DataSource = dt;
        }
        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTADETTMP";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@VT_FOLIO", TXTFOLIO.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    if (R["VT_FOLIO"].ToString() != "")
                    {
                        TXTFOLIO.Text = R["VT_FOLIO"].ToString();
                        TXTSERIE.Text = R["VT_SERIE"].ToString();
                        TXTISTIPODOCUMENTO.Text = R["VT_ID_TIPODOCTO"].ToString();
                        TXTMONTO.Text = R["VT_MONTO"].ToString();
                        CBCLIENTES.SelectedValue = R["VT_ID_CLIENTE"].ToString();
                        TXTIDALMACEN.Text = R["VT_ID_ALMACEN"].ToString();
                        DATETIMEFECHA.Value = Convert.ToDateTime(R["VT_FECHA"]);

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
                this.vENTA_DET_TMPTableAdapter.Fill(this.dsVentas.VENTA_DET_TMP);
            }
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTADETTMP";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@VT_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@VT_SERIE", TXTSERIE.Text);
            cmd.Parameters.AddWithValue("@VT_ID_TIPODOCTO", TXTISTIPODOCUMENTO.Text);
            cmd.Parameters.AddWithValue("@VT_MONTO", TXTMONTO.Text);
            cmd.Parameters.AddWithValue("@VT_ID_CLIENTE", CBCLIENTES.SelectedValue);
            cmd.Parameters.AddWithValue("@VT_ID_ALMACEN", TXTIDALMACEN.Text);
            cmd.Parameters.AddWithValue("@VT_FECHA", DATETIMEFECHA.Value);
            cmd.Parameters.AddWithValue("@VT_ID_PRODUCTO", CBPRODUCTOS.SelectedValue);
            cmd.Parameters.AddWithValue("@VT_CANTIDAD", TXTCANTIDAD.Text);
            cmd.Parameters.AddWithValue("@VT_IMPORTE", TXTIMPORTE.Text);
            cmd.Parameters.AddWithValue("@VT_IVA", TXTIVA.Text);
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
                this.vENTA_DET_TMPTableAdapter.Fill(this.dsVentas.VENTA_DET_TMP);
                limpiar();
            }
        }

        private void guardarventa()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTAS";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@VE_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@VE_SERIE", TXTSERIE.Text);
            cmd.Parameters.AddWithValue("@VE_ID_TIPODOCTO", TXTISTIPODOCUMENTO.Text);
            cmd.Parameters.AddWithValue("@VE_MONTO", TXTMONTO.Text);
            cmd.Parameters.AddWithValue("@VE_ID_CLIENTE", CBCLIENTES.SelectedValue);
            cmd.Parameters.AddWithValue("@VE_ID_ALMACEN", TXTIDALMACEN.Text);
            cmd.Parameters.AddWithValue("@VE_FECHA", DATETIMEFECHA.Value);


            SqlCommand cmd2 = new SqlCommand("", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "SP_VENTASDETALLES";
            cmd2.Parameters.AddWithValue("@OP", 2);
            cmd2.Parameters.AddWithValue("@VD_FOLIO", TXTFOLIO.Text);
            MessageBox.Show("Sus datos se guardaron correctamente");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.vENTA_DET_TMPTableAdapter.Fill(this.dsVentas.VENTA_DET_TMP);
                limpiar();
            }
        }

        private void eliminar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTADETTMP";
            cmd.Parameters.AddWithValue("@Op", 3);
            cmd.Parameters.AddWithValue("@VT_FOLIO", TXTFOLIO.Text);

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
                this.vENTA_DET_TMPTableAdapter.Fill(this.dsVentas.VENTA_DET_TMP);
                limpiar();
            }

        }

        private void eliminarventa()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTADETTMP";
            cmd.Parameters.AddWithValue("@Op", 4);
            cmd.Parameters.AddWithValue("@VT_FOLIO", TXTFOLIO.Text);

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
                this.vENTA_DET_TMPTableAdapter.Fill(this.dsVentas.VENTA_DET_TMP);
                limpiar();
            }

        }
        private void TXTISTIPODOCUMENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTMONTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDCLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDALMACEN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void BTNBUSCARFOLIO_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void VENTAS2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsVentas.VENTA_DET_TMP' Puede moverla o quitarla según sea necesario.
            this.vENTA_DET_TMPTableAdapter.Fill(this.dsVentas.VENTA_DET_TMP);
            llenarclientes();
            llenarproductos();

        }

        private void BTNMAS_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BTNMENOS_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void BTNVENDER_Click(object sender, EventArgs e)
        {
            guardarventa();
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            eliminarventa();
        }
    }
}
