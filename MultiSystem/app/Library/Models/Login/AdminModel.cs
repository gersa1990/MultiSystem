using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MultiSystem.core.DB;
using MultiSystem.Parameters;

namespace MultiSystem.adminModel
{
	public class AdminModel : IDatabase
	{

		public AdminModel()
		{
			
		}
		
		public List<Dictionary<string, string>> login(List<ParametersLogin> parameters)
		{
            string query = "SELECT * FROM admins INNER JOIN typesadmin ON typesadmin.idTypeAdmin = admins.typeAdmin WHERE admins.userNameAdmin = '" + ((ParametersLogin)parameters[0]).userName + "' AND  admins.passAdmin =  '" + ((ParametersLogin)parameters[0]).passWordName+"'";
            return this.db.Query("bookStore", query).rowArray();
		}
	}
}