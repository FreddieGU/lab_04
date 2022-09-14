

using System;

namespace lab_04
{
	public class Cadena
	{
		private String Cad;
		
		public Cadena()
		{
		}
		
		public String InvertirCadena(String palabra){
			Cad = "";	//Primero inicializamos la cadena en cadena vacía.
			for (int i = 0; i < palabra.Length; i++) {
				Cad = palabra[i] + Cad;
			}
			return Cad;
		}
		
		public short ContarVocales(String palabra){
			short cantidad=0;	
			char l;
			
			for (int i = 0; i < palabra.Length; i++) {
				l = Char.ToLower(palabra[i]); //Convertimos la letra a minuscula
				if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u') {
					cantidad++;
				}
			}
			return cantidad;
		}
		
		
		public int ContarPalabras(String palabra){
			Cad = palabra.TrimStart(' '); 	//Eliminamos espacios en blanco al inicio
			Cad = Cad.TrimEnd(' ');		//Eliminamos espacios en blanco al final
						
			String [] Arreglo = Cad.Split(' '); //Creamos un arreglo, una palabra por casilla
			
			return Arreglo.Length;				//Regresamos el tamaño del arreglo 
		}
		
		
		public int LetraPosicion(String palabra, Char letra){
			
			for (int i = 0; i < palabra.Length; i++) {
				if (char.ToLower(palabra[i]).Equals(letra)){
					//Leemos la letra de la posición i, la pasamos a minuscula en caso de
					//ser mayuscula, y comparamos con la letra que buscamos.
					return i; 	//retorna la posición cuando encuentra la letra						
				}
			}
			return -1;			//Si llega aquí, no encontro la letra en la cadena.
		}
		
		
	}
}
