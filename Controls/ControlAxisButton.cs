using System;
using UnityEngine;

namespace Bolt.Control
{
	public class ControlAxisButton : IControlAxis
	{
		
		private string trigger;
	
		public ControlAxisButton (string trigger)
		{
			this.trigger = trigger;
		}
		
		public float GetAxis()
		{
			var pos = Input.GetButton(trigger);

			if ( pos )
			{
				return 1f;
			} else {
				return 0f;
			}
		}
	}
}
