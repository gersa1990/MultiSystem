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
using MultiSystem.adminModel;
using MultiSystem.Parameters;

namespace MultiSystem.app.Library.Controllers
{
	public class AdminController
	{
        private List<ParametersLogin> fields;
        private List<Dictionary<string, string>> founded;
        private ParametersLogin objParameter;
		private AdminModel adminModel;
		
		private string userName = "";
		public string UserName
		{
			get 
			{
				return userName;
			}
			
			set
			{
				userName = value;
			}
		}
		
		private string passwordName = "";
		public string PasswordName
		{
			get 
			{
				return passwordName;
			}
			
			set
			{
				passwordName =  value;
			}
		}
		
		
		public List<Dictionary<string, string>> Login()
		{
            objParameter                = new ParametersLogin();
            adminModel                  = new AdminModel();
            objParameter.userName       = this.userName;
            objParameter.passWordName   = this.passwordName;

            fields = new List<ParametersLogin>();

            fields.Add(objParameter);

            return adminModel.login(fields);
		}
	}
}