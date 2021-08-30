using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_2
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void Btn_saludarClick(object sender, EventArgs e)
		{
			if(rbnt_azul.Checked){
				lbl_saludar.ForeColor=Color.Blue;
			}
			if(rbnt_rojo.Checked){
				lbl_saludar.ForeColor=Color.Red;
			}
			if(rbnt_amarillo.Checked){
				lbl_saludar.ForeColor=Color.Yellow;
			}
			lbl_saludar.Text= "Hola "+txt_nombre.Text;
		}
		
	}
}
