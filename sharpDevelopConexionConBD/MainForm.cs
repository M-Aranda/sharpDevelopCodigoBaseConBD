/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using sharpDevelopConexionConBD.Model;


namespace sharpDevelopConexionConBD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			Nacionalidad n=new Nacionalidad();
			n.Id=1;
			n.Nombre="Uruguayo";
			
			DAO_Nacionalidad dn= new DAO_Nacionalidad();
			
			MessageBox.Show(dn.Test());
			
			
		
		}
	}
}
