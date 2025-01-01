using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Mysql_Query_On_DataTable
{
	internal static class Program
	{
		[STAThread]
		 static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new Views.QueryShow());
		}

	}
}
