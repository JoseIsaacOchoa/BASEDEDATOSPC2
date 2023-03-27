using BASEDEDATOSPC2.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASEDEDATOSPC2
{
    public partial class PROVEEDORES : Form
    {
        public PROVEEDORES()
        {
            InitializeComponent();
        }

        private void PROVEEDORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet2.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet2.PROVEEDORES);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet2.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            consecutivo();
        }

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(PRO_ID),0) + 1 FROM PROVEEDORES";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTID.Text = dr.GetInt32(0).ToString();
                    //txtID.Text = dr[0].ToString();
                    //txtID.Text = dr["CONSECUTIVO"].ToString();
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
            TXTRFC.Clear();
            TXTCORREO.Clear();
            TXTLADA.Clear();
            TXTTELEFONO.Clear();
            TXTCALLE.Clear();
            TXTNUMEXT.Clear();
            TXTCUENTABANCARIA.Clear();
            TXTNOMBRECONTCTO.Clear();
            TXTTELCONTACTO.Clear();
            TXTREGIMEN.Clear();
            consecutivo();
        }

        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PRO_ID", TXTID.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    TXTID.Text = R["CL_ID"].ToString();
                    TXTNOMBRE.Text = R["CL_NOMBRE"].ToString();
                    TXTRFC.Text = R["CL_RFC"].ToString();
                    TXTCORREO.Text = R["CL_CORREO"].ToString();
                    TXTLADA.Text = R["CL_LADA"].ToString();
                    TXTTELEFONO.Text = R["CL_TELEFONO"].ToString();
                    TXTCALLE.Text = R["CL_CALLE"].ToString();
                    TXTNUMEXT.Text = R["CL_NUMERO_EXT"].ToString();
                    TXTCUENTABANCARIA.Text = R["CL_CTABANCARIA"].ToString();
                    TXTNOMBRECONTCTO.Text = R["CL_CONTACTO"].ToString();
                    TXTTELCONTACTO.Text = R["CL_TELEF_CONTACTO"].ToString();
                    TXTREGIMEN.Text = R["CL_REGIMEN"].ToString();
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
                this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet2.PROVEEDORES);
            }
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PRO_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@PRO_NOMBRE", TXTNOMBRE.Text);
            cmd.Parameters.AddWithValue("@PRO_RFC", TXTRFC.Text);
            cmd.Parameters.AddWithValue("@PRO_CORREO", TXTCORREO.Text);
            cmd.Parameters.AddWithValue("@PRO_LADA", TXTLADA.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEFONO", TXTTELEFONO.Text);
            cmd.Parameters.AddWithValue("@PRO_CALLE", TXTCALLE.Text);
            cmd.Parameters.AddWithValue("@PRO_NUMERO_EXT", TXTNUMEXT.Text);
            cmd.Parameters.AddWithValue("@PRO_CTABANCARIA", TXTCUENTABANCARIA.Text);
            cmd.Parameters.AddWithValue("@PRO_CONTACTO", TXTTELCONTACTO.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEF_CONTACTO", TXTTELCONTACTO.Text);
            cmd.Parameters.AddWithValue("@PRO_REGIMEN", TXTREGIMEN.Text);
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
                this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet2.PROVEEDORES);
                limpiar();
            }
        }

        private void elimnar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@CL_ID", TXTID.Text);

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
                this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet2.PROVEEDORES);
                limpiar();
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

        private void TXTNOMBRECONTCTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void TXTLADA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTNUMEXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTTELCONTACTO_KeyPress(object sender, KeyPressEventArgs e)
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
            elimnar();
        }
    }
}