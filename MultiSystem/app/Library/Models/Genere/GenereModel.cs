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

namespace MultiSystem.app.Library.Models
{
	public class GenereModel : IDatabase
	{
		public GenereModel()
		{
			// Insert code required on object creation below this point.
		}
		
		public List<Dictionary<string, string>> getGeneres()
		{
			return this.db.Select("bookStore","generesbook").resultArray();
		}
	}
}