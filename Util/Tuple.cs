// --------------------------------------------------------------------------
// Functional Programming in .NET - Chapter 3
// --------------------------------------------------------------------------
// NOTE: This library contains several useful classes for functional 
// programming in C# that we implemented in chapter 3 and that we'll 
// extend and use later in the book. Each secion is marked with a reference
// to a code listing or section in the book where it was discussed.
// --------------------------------------------------------------------------

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