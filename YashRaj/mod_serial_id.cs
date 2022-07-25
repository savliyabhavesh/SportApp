using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x02000051 RID: 81
	[StandardModule]
	internal sealed class mod_serial_id
	{
		// Token: 0x060014BD RID: 5309 RVA: 0x0026FB74 File Offset: 0x0026DF74
		public static string GetDriverSerialNumber()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
			object instance = objectValue;
			Type type = null;
			string memberName = "GetDrive";
			object[] array = new object[1];
			object[] array2 = array;
			int num = 0;
			object instance2 = objectValue;
			array2[num] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "GetDriveName", new object[]
			{
				Application.StartupPath
			}, null, null, null));
			object[] array3 = array;
			object[] arguments = array3;
			string[] argumentNames = null;
			Type[] typeArguments = null;
			bool[] array4 = new bool[]
			{
				true
			};
			object obj = NewLateBinding.LateGet(instance, type, memberName, arguments, argumentNames, typeArguments, array4);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "GetDriveName", new object[]
				{
					Application.StartupPath,
					RuntimeHelpers.GetObjectValue(array3[0])
				}, null, null, true, false);
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
			object instance3 = objectValue2;
			int num2;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(instance3, null, "isReady", new object[0], null, null, null)))
			{
				num2 = Conversions.ToInteger(NewLateBinding.LateGet(instance3, null, "serialNumber", new object[0], null, null, null));
			}
			else
			{
				num2 = 1;
			}
			num2.ToString("X2");
			mod_serial_id.serial_number = num2;
			string result="";
			return result;
		}

		// Token: 0x040008AC RID: 2220
		public static int serial_number;

		// Token: 0x040008AD RID: 2221
		public static string _mindi_hide;
	}
}
