/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of IDAO.
	/// </summary>
	public interface IDAO<T>
	{
		void Create(T ob);
        DataTable Read();
        void Update(T ob);
        void Delete(int id);

        DataTable BuscarPorRun(String run);
		
	}
}
