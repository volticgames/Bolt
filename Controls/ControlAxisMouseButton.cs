using System;
using UnityEngine;
namespace Control
{
	public class ControlAxisMouseButton : IControlAxis
	{
		private int trigger;
		
		public ControlAxisMouseButton (int trigger)
		{
			this.trigger = trigger;
		}
		
		public float GetAxis()
		{
			var pos = Input.GetMouseButton(trigger);
			
			if ( pos )
			{
				return 1f;
			} else {
				return 0f;
			}
		}
	}
}
