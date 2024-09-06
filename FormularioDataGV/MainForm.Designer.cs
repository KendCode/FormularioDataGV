/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 22/08/2024
 * Hora: 20:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FormularioDataGV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDetalle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.DataGridViewTextBoxColumn nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
		private System.Windows.Forms.TextBox txtNombre;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtDetalle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.CadetBlue;
			this.label1.Location = new System.Drawing.Point(405, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "PRODUCTOS";
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.CadetBlue;
			this.btnNuevo.Location = new System.Drawing.Point(46, 114);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(117, 38);
			this.btnNuevo.TabIndex = 1;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.CadetBlue;
			this.btnEliminar.Location = new System.Drawing.Point(46, 315);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(117, 38);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.CadetBlue;
			this.btnModificar.Location = new System.Drawing.Point(46, 242);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(123, 38);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "MODIFICAR";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
			this.btnAgregar.Location = new System.Drawing.Point(46, 180);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(117, 38);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(304, 153);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(196, 30);
			this.txtNombre.TabIndex = 5;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(304, 246);
			this.txtPrecio.Multiline = true;
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(196, 30);
			this.txtPrecio.TabIndex = 6;
			// 
			// txtDetalle
			// 
			this.txtDetalle.Location = new System.Drawing.Point(671, 153);
			this.txtDetalle.Multiline = true;
			this.txtDetalle.Name = "txtDetalle";
			this.txtDetalle.Size = new System.Drawing.Size(258, 139);
			this.txtDetalle.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.CadetBlue;
			this.label2.Location = new System.Drawing.Point(304, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.CadetBlue;
			this.label3.Location = new System.Drawing.Point(304, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Precio";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.CadetBlue;
			this.label4.Location = new System.Drawing.Point(671, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Detalle";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nro,
			this.nombre,
			this.precio,
			this.detalle});
			this.dgvProductos.Location = new System.Drawing.Point(304, 315);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.Size = new System.Drawing.Size(636, 228);
			this.dgvProductos.TabIndex = 11;
			this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductosCellContentClick);
			// 
			// nro
			// 
			this.nro.HeaderText = "NRO";
			this.nro.Name = "nro";
			// 
			// nombre
			// 
			this.nombre.HeaderText = "NOMBRE";
			this.nombre.Name = "nombre";
			// 
			// precio
			// 
			this.precio.HeaderText = "PRECIO";
			this.precio.Name = "precio";
			// 
			// detalle
			// 
			this.detalle.HeaderText = "DETALLE";
			this.detalle.Name = "detalle";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 606);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDetalle);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormularioDataGV";
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
