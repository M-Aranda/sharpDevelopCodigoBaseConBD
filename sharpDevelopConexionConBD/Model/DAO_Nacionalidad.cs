/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of DAO_Nacionalidad.
	/// </summary>
	public class DAO_Nacionalidad : Conexion, IDAO<Nacionalidad>
	{
		public DAO_Nacionalidad() : base("BDdePrueba")
		{
		}

		#region IDAO implementation

		public void Create(Nacionalidad ob)
		{
			MessageBox.Show("eh");
		}

		public System.Data.DataTable Read()
		{
			MessageBox.Show("eh");
			return null;
		}

		public void Update(Nacionalidad ob)
		{
			MessageBox.Show("eh");
		}

		public void Delete(int id)
		{
			MessageBox.Show("eh");
		}

		public System.Data.DataTable BuscarPorRun(string run)
		{
			MessageBox.Show("eh");
			return null;
		}
		
		public String Test(){
			return "yeh";
		}

		#endregion
	}
}
