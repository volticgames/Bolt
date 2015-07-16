using System;
using UnityEngine;

namespace Bolt.Animation
{
	[Serializable]
	public class AddedAnimation
	{
		public Texture2D texture;
		public float speed;
		public bool loop;

		public AddedAnimation ()
		{
		}
		
		public string GetName()
		{
			if (texture) return texture.name;
			else return null;
		}
	}
}

