
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab_04
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BtnInvertirClick(object sender, EventArgs e)
		{
			Cadena cad = new Cadena();  		//creamos el objeto
			String palabra = txtPalabra.Text;	//guardamos el texto en una variable
			
			String invertir;					//Aquí guardamos la cadena invertida
	
			invertir = cad.InvertirCadena(palabra);	//Invocamos al método invertirCadena
			
			listBoxHistorial.Items.Add(palabra + " (" +  invertir + ")");	
			//agregamos la palabra invertida al historial
		}
		
		
		
		void BtnVocalesClick(object sender, EventArgs e)
		{
			Cadena cad = new Cadena();  		//creamos el objeto
			String palabra = txtPalabra.Text;	//guardamos el texto en una variable
			
			short cantidad = 0;
			
			cantidad = cad.ContarVocales(palabra);
			
			listBoxHistorial.Items.Add(palabra + " (" +  cantidad + " vocales)");
			//agregamos la cantidad de vocales al historial
		}
		
		void BtnPalabrasClick(object sender, EventArgs e)
		{
			Cadena cad = new Cadena();  		//creamos el objeto
			String palabra = txtPalabra.Text;	//guardamos el texto en una variable
			
			int  cantidad_palabras = 0;
			
			cantidad_palabras = cad.ContarPalabras(palabra);
			
			listBoxHistorial.Items.Add(palabra.TrimStart(' ') + " (" +  cantidad_palabras + " palabras)");
			//agregamos la cantidad de palabras al historial
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//Realizamos un cast con i = 91 que correcponde a la letra 'a' en ascii, 122 a la 'z'
			for (int i = 97; i <= 122; i++) {
				comboBoxLetra.Items.Add((char)(i));
			}
			comboBoxLetra.SelectedIndex=0; //agregamos esta línea para que esté seleccionado
			//por defecto la letra 'a' que corresponde al indice 0 			
		}
		
		
		
		void BtnLetraClick(object sender, EventArgs e)
		{
			Cadena cad = new Cadena();  		//creamos el objeto
			String palabra = txtPalabra.Text;	//guardamos el texto en una variable
			
			int  indice_letra = 0;
			char letra = comboBoxLetra.SelectedItem.ToString()[0];
			//obtenemos la cadena de la letra seleccionada y con [0] extraemos el
			//primer caracter de la cadena, que es la letra
			
			
			indice_letra=cad.LetraPosicion(palabra, letra);
			
			
			listBoxHistorial.Items.Add(palabra + " (indice = " +  indice_letra + " )");
			//agregamos el indice al historial
		}
		
		
	}
}

