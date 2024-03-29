﻿using System;
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
    public partial class COMPRAS : Form
    {
        public COMPRAS()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            TXTFOLIO.Clear();
            TXTSERIE.Clear();
            TXTISTIPODOCUMENTO.Clear();
            TXTMONTO.Clear();
            CBPROVEEDOR.SelectedIndex = 1;
            CBALMACEN.SelectedIndex = 1;
            TXTFACTURA.Clear();
            DATETIMEFECHA.Value = DateTime.Today;
            CBPRODUCTOS.SelectedIndex = 1;
            TXTCANTIDAD.Clear();
            TXTIMPORTE.Clear();
            TXTIVA.Clear();
            TXTIDUBICACION.Clear();
        }

        private void limpiar2()
        {
            CBPRODUCTOS.SelectedIndex = 1;
            TXTCANTIDAD.Clear();
            TXTIMPORTE.Clear();
            TXTIVA.Clear();
            TXTIDUBICACION.Clear();
        }

        private void buscar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRADETTMP";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@CT_FOLIO", TXTFOLIO.Text);
            SqlDataReader R;

            try
            {
                con.Open();
                R = cmd.ExecuteReader();
                if (R.Read())
                {
                    if (R["CT_FOLIO"].ToString() != "")
                    {
                        TXTFOLIO.Text = R["CT_FOLIO"].ToString();
                        TXTSERIE.Text = R["CT_SERIE"].ToString();
                        TXTISTIPODOCUMENTO.Text = R["CT_ID_TIPODOCTO"].ToString();
                        TXTMONTO.Text = R["CT_MONTO"].ToString();
                        CBPROVEEDOR.SelectedValue = R["CT_ID_PROVEEDOR"].ToString();
                        CBALMACEN.SelectedValue = R["CT_ID_ALMACEN"].ToString();
                        TXTFACTURA.Text = R["CT_FACTURA"].ToString();
                        DATETIMEFECHA.Value = Convert.ToDateTime(R["CT_FECHA"]);

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
                this.cOMPRA_DET_TMPTableAdapter.Fill(this.dsComprasTemporal.COMPRA_DET_TMP);
            }
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRADETTMP";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CT_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@CT_SERIE", TXTSERIE.Text);
            cmd.Parameters.AddWithValue("@CT_ID_TIPODOCTO", TXTISTIPODOCUMENTO.Text);
            cmd.Parameters.AddWithValue("@CT_MONTO", TXTMONTO.Text);
            cmd.Parameters.AddWithValue("@CT_ID_PROVEEDOR", CBPROVEEDOR.SelectedValue);
            cmd.Parameters.AddWithValue("@CT_ID_ALMACEN", CBALMACEN.SelectedValue);
            cmd.Parameters.AddWithValue("@CT_FACTURA", TXTFACTURA.Text);
            cmd.Parameters.AddWithValue("@CT_FECHA", DATETIMEFECHA.Value);
            cmd.Parameters.AddWithValue("@CT_ID_PRODUCTO", CBPRODUCTOS.SelectedValue);
            cmd.Parameters.AddWithValue("@CT_CANTIDAD", TXTCANTIDAD.Text);
            cmd.Parameters.AddWithValue("@CT_IMPORTE", TXTIMPORTE.Text);
            cmd.Parameters.AddWithValue("@CT_IVA", TXTIVA.Text);
            cmd.Parameters.AddWithValue("@CT_UBICACION", TXTIDUBICACION.Text);

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
                this.cOMPRA_DET_TMPTableAdapter.Fill(this.dsComprasTemporal.COMPRA_DET_TMP);
                limpiar2();
            }
        }

        private void guardarcompra()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRAS";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CO_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@CO_SERIE", TXTSERIE.Text);
            cmd.Parameters.AddWithValue("@CO_ID_TIPODOCTO", TXTISTIPODOCUMENTO.Text);
            cmd.Parameters.AddWithValue("@CO_MONTO", TXTMONTO.Text);
            cmd.Parameters.AddWithValue("@CO_ID_PROVEEDOR", CBPROVEEDOR.SelectedValue);
            cmd.Parameters.AddWithValue("@CO_ID_ALMACEN", CBALMACEN.SelectedValue);
            cmd.Parameters.AddWithValue("@CO_FACTURA", TXTFACTURA.Text);
            cmd.Parameters.AddWithValue("@CO_FECHA", DATETIMEFECHA.Value);


            SqlCommand cmd2 = new SqlCommand("", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "SP_COMPRAS_DETALLES";
            cmd2.Parameters.AddWithValue("@OP", 2);
            cmd2.Parameters.AddWithValue("@CD_FOLIO", TXTFOLIO.Text);
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
                this.cOMPRA_DET_TMPTableAdapter.Fill(this.dsComprasTemporal.COMPRA_DET_TMP);
                limpiar();
            }
        }

        private void eliminar()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRADETTMP";
            cmd.Parameters.AddWithValue("@Op", 3);
            cmd.Parameters.AddWithValue("@CT_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@CT_ID_PRODUCTO", CBPRODUCTOS.SelectedValue);
            cmd.Parameters.AddWithValue("@CT_CANTIDAD", TXTCANTIDAD.Text);
            cmd.Parameters.AddWithValue("@CT_IMPORTE", TXTIMPORTE.Text);
            cmd.Parameters.AddWithValue("@CT_IVA", TXTIVA.Text);

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
                this.cOMPRA_DET_TMPTableAdapter.Fill(this.dsComprasTemporal.COMPRA_DET_TMP);
                limpiar();
            }

        }

        private void cancelarcompra()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRADETTMP";
            cmd.Parameters.AddWithValue("@Op", 4);
            cmd.Parameters.AddWithValue("@CT_FOLIO", TXTFOLIO.Text);

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
                this.cOMPRA_DET_TMPTableAdapter.Fill(this.dsComprasTemporal.COMPRA_DET_TMP);
                limpiar();
            }

        }

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(CONEXION.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(CO_FOLIO),0) + 1 AS CONSECUTIVO FROM COMPRAS";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTFOLIO.Text = dr.GetInt32(0).ToString();
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

        private void llenarproveedores()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CONEXION.conectar()))
            {
                string query = "SELECT PRO_ID, PRO_NOMBRE FROM PROVEEDORES";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            CBPROVEEDOR.DisplayMember = "PRO_NOMBRE";
            CBPROVEEDOR.ValueMember = "PRO_ID";
            CBPROVEEDOR.DataSource = dt;
        }

        private void llenaralmacenes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(CONEXION.conectar()))
            {
                string query = "SELECT AL_ID, AL_NOMBRE FROM ALMACENES";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            CBALMACEN.DisplayMember = "AL_NOMBRE";
            CBALMACEN.ValueMember = "AL_ID";
            CBALMACEN.DataSource = dt;
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

        private void TXTFOLIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        private void TXTIDPROVEEDOR_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void COMPRAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsComprasTemporal.COMPRA_DET_TMP' Puede moverla o quitarla según sea necesario.
            this.cOMPRA_DET_TMPTableAdapter.Fill(this.dsComprasTemporal.COMPRA_DET_TMP);
            llenarproveedores();
            llenaralmacenes();
            llenarproductos();
            consecutivo();

        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            guardarcompra();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            cancelarcompra();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTNINSERTAR_Click(object sender, EventArgs e)
        {
        }

        private void BTNMENOS_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void BTNMAS_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
