using UnityEngine;
using System.Collections;

namespace Doublejump.Animation
{
	public class SpriteCollection
	{
		private Sprite[] sprites;
		private string[] names;
		
		public SpriteCollection(string spritesheet)
		{
			sprites = Resources.LoadAll<Sprite>(spritesheet);
			names = new string[sprites.Length];
			
			for(var i = 0; i < names.Length; i++)
			{
				names[i] = sprites[i].name;
			}
		}
		
		public int SpriteCount()
		{
			return sprites.Length;
		}
		
		public Sprite GetSpriteByIndex(int index)
		{
			return sprites[index];
		}
		
		public Sprite GetSprite(string name)
		{
			return sprites[System.Array.IndexOf(names, name)];
		}
	}
}