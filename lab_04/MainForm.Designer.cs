/*
 * Creado por SharpDevelop.
 * Usuario: Hector
 * Fecha: 26/10/2020
 * Hora: 01:59 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace lab_04
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.listBoxHistorial = new System.Windows.Forms.ListBox();
			this.btnInvertir = new System.Windows.Forms.Button();
			this.btnVocales = new System.Windows.Forms.Button();
			this.btnPalabras = new System.Windows.Forms.Button();
			this.btnLetra = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxLetra = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Palabra:";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(67, 16);
			this.txtPalabra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(269, 20);
			this.txtPalabra.TabIndex = 1;
			// 
			// listBoxHistorial
			// 
			this.listBoxHistorial.FormattingEnabled = true;
			this.listBoxHistorial.Location = new System.Drawing.Point(18, 45);
			this.listBoxHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBoxHistorial.Name = "listBoxHistorial";
			this.listBoxHistorial.Size = new System.Drawing.Size(319, 134);
			this.listBoxHistorial.TabIndex = 2;
			// 
			// btnInvertir
			// 
			this.btnInvertir.Location = new System.Drawing.Point(352, 15);
			this.btnInvertir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(139, 23);
			this.btnInvertir.TabIndex = 3;
			this.btnInvertir.Text = "Invertir cadena";
			this.btnInvertir.UseVisualStyleBackColor = true;
			this.btnInvertir.Click += new System.EventHandler(this.BtnInvertirClick);
			// 
			// btnVocales
			// 
			this.btnVocales.Location = new System.Drawing.Point(352, 48);
			this.btnVocales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnVocales.Name = "btnVocales";
			this.btnVocales.Size = new System.Drawing.Size(139, 23);
			this.btnVocales.TabIndex = 4;
			this.btnVocales.Text = "Contar vocales";
			this.btnVocales.UseVisualStyleBackColor = true;
			this.btnVocales.Click += new System.EventHandler(this.BtnVocalesClick);
			// 
			// btnPalabras
			// 
			this.btnPalabras.Location = new System.Drawing.Point(354, 81);
			this.btnPalabras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnPalabras.Name = "btnPalabras";
			this.btnPalabras.Size = new System.Drawing.Size(137, 23);
			this.btnPalabras.TabIndex = 5;
			this.btnPalabras.Text = "Contrar palabras";
			this.btnPalabras.UseVisualStyleBackColor = true;
			this.btnPalabras.Click += new System.EventHandler(this.BtnPalabrasClick);
			// 
			// btnLetra
			// 
			this.btnLetra.Location = new System.Drawing.Point(354, 114);
			this.btnLetra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLetra.Name = "btnLetra";
			this.btnLetra.Size = new System.Drawing.Size(137, 23);
			this.btnLetra.TabIndex = 6;
			this.btnLetra.Text = "Buscar letra en palabra";
			this.btnLetra.UseVisualStyleBackColor = true;
			this.btnLetra.Click += new System.EventHandler(this.BtnLetraClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(357, 150);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Letra";
			// 
			// comboBoxLetra
			// 
			this.comboBoxLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLetra.FormattingEnabled = true;
			this.comboBoxLetra.Location = new System.Drawing.Point(410, 148);
			this.comboBoxLetra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxLetra.Name = "comboBoxLetra";
			this.comboBoxLetra.Size = new System.Drawing.Size(82, 21);
			this.comboBoxLetra.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 204);
			this.Controls.Add(this.comboBoxLetra);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLetra);
			this.Controls.Add(this.btnPalabras);
			this.Controls.Add(this.btnVocales);
			this.Controls.Add(this.btnInvertir);
			this.Controls.Add(this.listBoxHistorial);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "lab_04";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBoxLetra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLetra;
		private System.Windows.Forms.Button btnPalabras;
		private System.Windows.Forms.Button btnVocales;
		private System.Windows.Forms.Button btnInvertir;
		private System.Windows.Forms.ListBox listBoxHistorial;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label1;
	}
}
