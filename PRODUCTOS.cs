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
    public partial class PRODUCTOS : Form
    {
        public PRODUCTOS()
        {
            InitializeComponent();
        }

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(PR_ID),0) + 1 AS CONSECUTIVO FROM PRODUCTOS";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTID.Text = dr.GetInt32(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron datos, error: " + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void limpiar()
        {
            TXTID.Clear();
            TXTNOMBRE.Clear();
            TXTIDUNIDAD.Clear();
            TXTSTOCKMIN.Clear();
            TXTSTOCKMAX.Clear();
            TXTIDTP.Clear();
            TXTPRECIO.Clear();
            TXTIVA.Clear();
            consecutivo();
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PR_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@PR_NOMBRE", TXTNOMBRE.Text);
            cmd.Parameters.AddWithValue("@PR_ID_UNIDAD", TXTIDUNIDAD.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MIN", TXTSTOCKMIN.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MAX", TXTSTOCKMAX.Text);
            cmd.Parameters.AddWithValue("@PR_ID_TP", TXTIDTP.Text);
            cmd.Parameters.AddWithValue("@PR_PRECIO", TXTPRECIO.Text);
            cmd.Parameters.AddWithValue("@PR_IVA", TXTIVA.Text);
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
                this.pRODUCTOSTableAdapter1.Fill(this.dsProductos.PRODUCTOS);
                limpiar();
            }
        }

        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PR_ID", TXTID.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    TXTID.Text = R["PR_ID"].ToString();
                    TXTNOMBRE.Text = R["PR_NOMBRE"].ToString();
                    TXTIDUNIDAD.Text = R["PR_ID_UNIDAD"].ToString();
                    TXTSTOCKMIN.Text = R["PR_STOCK_MIN"].ToString();
                    TXTSTOCKMAX.Text = R["PR_STOCK_MAX"].ToString();
                    TXTIDTP.Text = R["PR_ID_TP"].ToString();
                    TXTPRECIO.Text = R["PR_PRECIO"].ToString();
                    TXTIVA.Text = R["PR_IVA"].ToString();
                }
                MessageBox.Show("Datos encontrados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.pRODUCTOSTableAdapter1.Fill(this.dsProductos.PRODUCTOS);
            }
        }

        private void eliminar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@Op", 3);
            cmd.Parameters.AddWithValue("@PR_ID", TXTID.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sus datos se eliminaron correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron eliminar los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.pRODUCTOSTableAdapter1.Fill(this.dsProductos.PRODUCTOS);
                limpiar();
            }
        }

        private void existencia()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 4);
            cmd.Parameters.AddWithValue("@PR_ID", TXTID.Text);
            SqlDataReader R;

            try
            {
                int exist = 0;
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    exist = Convert.ToInt32(R["EXISTENCIA"]);
                }
                MessageBox.Show("Cantidad en existencia: " + exist);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.pRODUCTOSTableAdapter1.Fill(this.dsProductos.PRODUCTOS);
            }
        }
        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProductos.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter1.Fill(this.dsProductos.PRODUCTOS);


        }

        private void TXTID_KeyPress(object sender, KeyPressEventArgs e)
            {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDUNIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTSTOCKMIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTSTOCKMAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTPRECIO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void BTNEXISTENCIA_Click(object sender, EventArgs e)
        {
            existencia();
        }
    }
}
