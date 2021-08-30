/*
 * Created by SharpDevelop.
 * User: IPPESSI
 * Date: 30/8/2021
 * Time: 20:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_saludar;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.RadioButton rbnt_rojo;
		private System.Windows.Forms.RadioButton rbnt_azul;
		private System.Windows.Forms.RadioButton rbnt_amarillo;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.Label lbl_saludar;
		
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
			this.btn_saludar = new System.Windows.Forms.Button();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.rbnt_rojo = new System.Windows.Forms.RadioButton();
			this.rbnt_azul = new System.Windows.Forms.RadioButton();
			this.rbnt_amarillo = new System.Windows.Forms.RadioButton();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.lbl_saludar = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_saludar
			// 
			this.btn_saludar.Location = new System.Drawing.Point(100, 163);
			this.btn_saludar.Name = "btn_saludar";
			this.btn_saludar.Size = new System.Drawing.Size(75, 23);
			this.btn_saludar.TabIndex = 0;
			this.btn_saludar.Text = "Saludar";
			this.btn_saludar.UseVisualStyleBackColor = true;
			this.btn_saludar.Click += new System.EventHandler(this.Btn_saludarClick);
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(12, 9);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(68, 17);
			this.lbl_nombre.TabIndex = 1;
			this.lbl_nombre.Text = "Nombre:";
			// 
			// rbnt_rojo
			// 
			this.rbnt_rojo.Location = new System.Drawing.Point(40, 58);
			this.rbnt_rojo.Name = "rbnt_rojo";
			this.rbnt_rojo.Size = new System.Drawing.Size(104, 24);
			this.rbnt_rojo.TabIndex = 2;
			this.rbnt_rojo.TabStop = true;
			this.rbnt_rojo.Text = "Rojo";
			this.rbnt_rojo.UseVisualStyleBackColor = true;
			// 
			// rbnt_azul
			// 
			this.rbnt_azul.Location = new System.Drawing.Point(40, 88);
			this.rbnt_azul.Name = "rbnt_azul";
			this.rbnt_azul.Size = new System.Drawing.Size(104, 24);
			this.rbnt_azul.TabIndex = 3;
			this.rbnt_azul.TabStop = true;
			this.rbnt_azul.Text = "Azul";
			this.rbnt_azul.UseVisualStyleBackColor = true;
			// 
			// rbnt_amarillo
			// 
			this.rbnt_amarillo.Location = new System.Drawing.Point(40, 118);
			this.rbnt_amarillo.Name = "rbnt_amarillo";
			this.rbnt_amarillo.Size = new System.Drawing.Size(104, 24);
			this.rbnt_amarillo.TabIndex = 4;
			this.rbnt_amarillo.TabStop = true;
			this.rbnt_amarillo.Text = "Amarillo";
			this.rbnt_amarillo.UseVisualStyleBackColor = true;
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(100, 6);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(100, 20);
			this.txt_nombre.TabIndex = 5;
			// 
			// lbl_saludar
			// 
			this.lbl_saludar.Location = new System.Drawing.Point(72, 206);
			this.lbl_saludar.Name = "lbl_saludar";
			this.lbl_saludar.Size = new System.Drawing.Size(137, 23);
			this.lbl_saludar.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lbl_saludar);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.rbnt_amarillo);
			this.Controls.Add(this.rbnt_azul);
			this.Controls.Add(this.rbnt_rojo);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.btn_saludar);
			this.Name = "MainForm";
			this.Text = "Ejercicio 2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
