using UnityEngine;

namespace Bolt.Util
{
	public static class RectUtil
	{
		
		/// <summary>
		/// Find the intersection of two rectangles, returns the amount of overlap as a Rectangle.
		/// </summary>
		/// <param name="one">One.</param>
		/// <param name="two">Two.</param>
		public static Rect Intersect(Rect one, Rect two)
		{

            if (one.Overlaps(two))
            {  
               	float left, right, top, bottom;
               	
               	if (one.xMin > two.xMin)
               	{
               		left = one.xMin;
               	} else {
               		left = two.xMin;
               	}
               	
               	if (one.xMax < two.xMax)
               	{
               		right = one.xMax;
               	} else{
               		right = two.xMax;
               	}
               	
               	if (one.yMax < two.yMax)
               	{
               		top = one.yMax;
               	} else {
               		top = two.yMax;
               	}
               	
               	if (one.yMin > two.yMin)
               	{
               		bottom = one.yMin;
               	} else {
               		bottom = two.yMin;
               	}
				
                return new Rect(left, top, right - left, top - bottom);
            } else {
                return new Rect(0, 0, 0, 0);
            }
            
		}
	
		/// <summary>
		/// Is this a valid rectangle?
		/// </summary>
		/// <param name="rect">Rect.</param>
		public static bool Exists(Rect rect)
		{
			return (rect.width > 0) && (rect.height > 0);
		}
	}
}

