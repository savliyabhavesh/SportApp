using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using App.Service;

namespace YashAksh
{
	// Token: 0x02000058 RID: 88
	[StandardModule]
	internal sealed class Module1
	{
		
		//public static OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["YashAksh.Properties.Settings.MY_DBConnectionString"].ToString());
		public static OleDbConnection conn = new OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {Environment.CurrentDirectory}\\DB\\{BaseService.DbName};Persist Security Info=False;Jet OLEDB:Database Password=s@h#u$b%h@108");

		// Token: 0x040009FF RID: 2559
		public static object dppname;

		// Token: 0x04000A00 RID: 2560
		public static int modifypartyid = 0;

		// Token: 0x04000A02 RID: 2562
		public static string modifypartyname = "";

		// Token: 0x04000A00 RID: 2560
		public static int modifysessionid = 0;

		// Token: 0x04000A02 RID: 2562
		public static string modifysessionname = "";

		// Token: 0x04000A00 RID: 2560
		public static int modifymatchid = 0;

		// Token: 0x04000A01 RID: 2561
		public static int idnewmach;

		//// Token: 0x04000A03 RID: 2563
		//public static int Cupidfind;

		// Token: 0x04000A04 RID: 2564
		public static int machid;

		public static bool chkmatchbook;

		//// Token: 0x04000A05 RID: 2565
		//public static int Sessionmodify;

		// Token: 0x04000A06 RID: 2566
		public static int mdeclare;

		//// Token: 0x04000A07 RID: 2567
		//public static int sessiondclar;

		// Token: 0x04000A08 RID: 2568
		public static int matchbooklist;

		//// Token: 0x04000A09 RID: 2569
		//public static int cupid;

		//// Token: 0x04000A0A RID: 2570
		//public static double bal;

		//// Token: 0x04000A0B RID: 2571
		//public static object match1;

		//// Token: 0x04000A0C RID: 2572
		//public static object match2;

		//// Token: 0x04000A0D RID: 2573
		//public static object match3;

		//// Token: 0x04000A0E RID: 2574
		//public static double ma;

		//// Token: 0x04000A0F RID: 2575
		//public static double mat;

		// Token: 0x04000A10 RID: 2576
		public static object name1;

		public static int tossmatchid;

		//// Token: 0x04000A11 RID: 2577
		//public static object matchid;

		// Token: 0x04000A12 RID: 2578
		public static object sonu;

		// Token: 0x04000A13 RID: 2579
		public static object sessionid;

		//// Token: 0x04000A14 RID: 2580
		//public static object sessiontype;

		//// Token: 0x04000A15 RID: 2581
		//public static object sessionname;

		// Token: 0x04000A16 RID: 2582
		public static object tranID;

		//// Token: 0x04000A17 RID: 2583
		//public static int npadd;

		// Token: 0x04000A18 RID: 2584
		public static int IDCUP;

		//// Token: 0x04000A19 RID: 2585
		//public static int ses;

		//// Token: 0x04000A1A RID: 2586
		//public static object sessionALL;

		// Token: 0x04000A1B RID: 2587
		public static int nehaid;

		// Token: 0x04000A1C RID: 2588
		public static int Matchdecalerd;

		//// Token: 0x04000A1D RID: 2589
		//public static object Session_Fipty1;

		//// Token: 0x04000A1E RID: 2590
		//public static int AKDNumbare;

		//// Token: 0x04000A1F RID: 2591
		//public static object akdname1;

		//// Token: 0x04000A20 RID: 2592
		//public static string SerialNO;

		// Token: 0x04000A22 RID: 2594
		public static object myexit;

		// Token: 0x04000A23 RID: 2595
		public static double TotalAmount;

		// Token: 0x04000A24 RID: 2596
		public static double CustBalance;

		// Token: 0x04000A25 RID: 2597
		public static double mode1;

		// Token: 0x04000A26 RID: 2598
		public static double mode2;

		// Token: 0x04000A27 RID: 2599
		public static string balancelimits;

		//// Token: 0x04000A28 RID: 2600
		//public static string sessiondelc;

		public static string decimalnumberformat = "";
		public static string NumFormat = "";

		public static string commtype = "";

		public static bool ismatchbookpopupopen = false;

		public static string exp1_matchbook_total = "";
		public static string exp2_matchbook_total = "";
		public static string exp3_matchbook_total = "";
		public static string exp4_matchbook_total = "";

		public static DataTable DtMatch;


		public static bool isamountfirst = false;
		public static bool isratefirst = false;

		public static bool isntposition = false;

		public static bool isclientreport = false;
		public static string SetNumFormat(object value, string s)
        {
			string str = "";
			if (NumFormat == "")
            {
				str = Conversions.ToString(Math.Round(Conversion.Val(value)));
			}
			else
            {
				str = Strings.Format(Conversion.Val(value), NumFormat);
			}
			return str;
        }

	}
}
