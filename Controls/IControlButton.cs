using System;

namespace Bolt.Control
{
	public interface IControlButton
	{
	
		bool IsDown();
		bool JustPressed();
		bool JustReleased();
		void Update();
	
	}
}

