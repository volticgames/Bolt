using System;
using UnityEngine;

namespace Bolt.Control
{
	public class ControlButtonMouseButton : IControlButton
	{ 
	
		private int index;
	
		public ControlButtonMouseButton (int index)
		{
			this.index = index;
		}
		
		public bool IsDown()
		{
			return Input.GetMouseButton(index);
		}
		
		public bool JustPressed()
		{
			return Input.GetMouseButtonDown(index);	
		}
		
		public bool JustReleased()
		{	
			return Input.GetMouseButtonUp(index);
		}
		
		public void Update()
		{
		
		}
		
	}
}

