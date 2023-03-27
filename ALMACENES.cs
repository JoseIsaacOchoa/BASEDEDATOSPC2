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
    public partial class ALMACENES : Form
    {
        public ALMACENES()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAlmacen.ALMACENES' Puede moverla o quitarla según sea necesario.
            this.aLMACENESTableAdapter1.Fill(this.dsAlmacen.ALMACENES);
            
            consecutivo();
        }

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(AL_ID),0) + 1 FROM ALMACENES";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTNID.Text = dr.GetInt32(0).ToString();
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
            TXTNID.Clear();
            TXTNOMBRE.Clear();
            consecutivo();
        }
        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@AL_ID", TXTNID.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    TXTNID.Text = R["AL_ID"].ToString();
                    TXTNOMBRE.Text = R["AL_NOMBRE"].ToString();
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
                this.aLMACENESTableAdapter1.Fill(this.dsAlmacen.ALMACENES);
            }
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@AL_ID", TXTNID.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE", TXTNOMBRE.Text);
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
                this.aLMACENESTableAdapter1.Fill(this.dsAlmacen.ALMACENES);
                limpiar();
            }
        }

        private void elimnar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@AL_ID", TXTNID.Text);

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
                this.aLMACENESTableAdapter1.Fill(this.dsAlmacen.ALMACENES);
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
            elimnar();
        }
    }
}
