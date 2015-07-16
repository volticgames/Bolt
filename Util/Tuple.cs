using System;
using System.Collections.Generic;

namespace Eppy
{
    // Listing 3.8: Improved type inference for tuples in C#

    /// <summary>
    /// Utility class that simplifies cration of tuples by using 
    /// method calls instead of constructor calls
    /// </summary>
    public class Tuple<A, B>
    {
		private A one;
		private B two;

		public A first
		{
			get {
				return one; 
			}
		}

		public B second
		{
			get {
				return two; 
			}
		}

        public Tuple(A first, B second)
		{
			this.one = first;
			this.two = second;
		}

		public override string ToString ()
		{
			return string.Format ("[Tuple: first={0}, second={1}]", first, second);
		}
    }

	
}