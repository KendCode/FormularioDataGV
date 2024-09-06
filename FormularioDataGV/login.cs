/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 22/08/2024
 * Hora: 21:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioDataGV
{
	/// <summary>
	/// Description of login.
	/// </summary>
	public partial class login : Form
	{
		public login()
		{
			
			InitializeComponent();
			
		}
		void BtnIngresarClick(object sender, EventArgs e)
		{
			string usu = txtUsuario.Text;
			string con = txtContrasena.Text;
			if(usu.Equals("kender") && con.Equals("12345")){
				MessageBox.Show("Bienvenido "+usu);
				MainForm MF = new MainForm();
				this.Hide();
				MF.ShowDialog();
				this.Show();
			}
			else{
				lblError.Text = "Usuario o contraseña no concide. Vuelva a intentar";
				txtUsuario.Clear();
				txtContrasena.Clear();
				txtUsuario.Focus();
			}
		}
	}
}
