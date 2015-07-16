using UnityEngine;
using System.Collections;
using System.Text;

namespace Bolt {
	public class Logger
	{
		private static string buildString(params object[] values)
		{
			var stringBuilder = new StringBuilder();
			
			foreach (var obj in values)
			{
				stringBuilder.Append(obj);
				stringBuilder.Append(", ");
			}
			
			return stringBuilder.ToString();
		}
	
		public static void Format(string formatString, params object[] values)
		{
			Debug.Log (string.Format (formatString, values));
		}
		
		public static void Log(params object[] values)
		{
			Debug.Log (buildString(values));
		}
		
		public static void FormatWarning(string formatString, params object[] values)
		{
			Debug.LogWarning (string.Format (formatString, values));
		}
		
		public static void LogWarning(params object[] values)
		{
			Debug.LogWarning (buildString(values));
		}
		
		public static void FormatError(string formatString, params object[] values)
		{
			Debug.LogError (string.Format (formatString, values));
		}
		
		public static void LogError(params object[] values)
		{
			Debug.LogError (buildString(values));
		}
	}
}