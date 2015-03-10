using UnityEngine;
using System.Collections;

namespace Bolt {
	public static class ArrayExtensions {
		public static void Fill<T>(this T[] originalArray, T with) {
			for(int i = 0; i < originalArray.Length; i++){
				originalArray[i] = with;
			}
		}  
		
		public static void Fill<T>(this T[,] originalArray, T with) {
			for(int i = 0; i < originalArray.GetLength(0); i++){
				for (int j = 0; j < originalArray.GetLength(1); j++)
				{
					originalArray[i, j] = with;	
				}
			}
		}  
	}
}