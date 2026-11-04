/*
 * Created by SharpDevelop.
 * User: CC2_PC46
 * Date: 04/11/2026
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_2._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "Papois" && txtContraseña.Text == "6767")
            {
                Form1 F = new Form1();
                F.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
		}
	}
}
