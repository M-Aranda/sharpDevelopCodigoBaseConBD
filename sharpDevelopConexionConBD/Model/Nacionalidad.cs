/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of Nacionalidad.
	/// </summary>
	public class Nacionalidad
	{
		int id;
		String nombre;

		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}
		
		
		public Nacionalidad()
		{

			
		}
	}
}
