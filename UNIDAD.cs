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
    public partial class UNIDAD : Form
    {
        public UNIDAD()
        {
            InitializeComponent();
        }

        private void UNIDAD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsUNIDAD.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter1.Fill(this.dsUNIDAD.UNIDAD);
            consecutivo();
        }

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(UN_ID),0) + 1 FROM UNIDAD";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTNID.Text = dr.GetInt32(0).ToString();
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
            TXTNID.Clear();
            TXTDESCRIPCION.Clear();
            consecutivo();
        }

        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@UN_ID", TXTNID.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    TXTNID.Text = R["UN_ID"].ToString();
                    TXTDESCRIPCION.Text = R["UN_DESCRIPCION"].ToString();
                    MessageBox.Show("Datos encontrados");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron los datos, error: " + ex);
            }
            finally
            {
                con.Close();
                this.uNIDADTableAdapter1.Fill(this.dsUNIDAD.UNIDAD);
            }
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@UN_ID", TXTNID.Text);
            cmd.Parameters.AddWithValue("@UN_DESCRIPCION", TXTDESCRIPCION.Text);
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
                this.uNIDADTableAdapter1.Fill(this.dsUNIDAD.UNIDAD);
                limpiar();
            }
        }

        private void elimnar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@UN_ID", TXTNID.Text);

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
                this.uNIDADTableAdapter1.Fill(this.dsUNIDAD.UNIDAD);
                limpiar();
            }
        }

        private void TXTNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTDESCRIPCION_KeyPress(object sender, KeyPressEventArgs e)
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
            elimnar();
        }
    }
}
