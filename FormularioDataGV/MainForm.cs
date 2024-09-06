/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 22/08/2024
 * Hora: 20:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioDataGV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int n = 1;
		int fila;
		public MainForm()
		{

			InitializeComponent();
			
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			Limpiar();
			btnAgregar.Enabled = true;
		}
		void Limpiar(){
			txtNombre.Clear();
			txtPrecio.Clear();
			txtDetalle.Clear();
			btnModificar.Enabled = false;
			btnEliminar.Enabled = false;
			txtNombre.Focus();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			string nom, pre, de;
			nom = txtNombre.Text;
			pre = txtPrecio.Text;
			de = txtDetalle.Text;
			dgvProductos.Rows.Add(n,nom,pre,de);
			n++;
			Limpiar();
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			dgvProductos[1,fila].Value = txtNombre.Text;
			dgvProductos[2,fila].Value = txtPrecio.Text;
			dgvProductos[3,fila].Value = txtDetalle.Text;
			Limpiar();
		}
		void DgvProductosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fila = dgvProductos.CurrentRow.Index;
			txtNombre.Text = dgvProductos[1,fila].Value.ToString();
			txtPrecio.Text = dgvProductos[2,fila].Value.ToString();
			txtDetalle.Text = dgvProductos[3,fila].Value.ToString();
			btnModificar.Enabled=true;
			btnEliminar.Enabled=true;
			btnAgregar.Enabled=false;
			txtNombre.Focus();
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			dgvProductos.Rows.RemoveAt(fila);
		}
	}
}
