using UnityEngine;
using System.Collections;

namespace Bolt {
	public class Tile : MonoBehaviour {
	
		public Texture2D tileset;
		private Sprite[] sprites;
		public int tile;
		public TileGrid tilegrid;
		
		/// <summary>
		/// Get a list of tiles, set by the tilegrid.
		/// </summary>
		/// <param name="sprites">Sprites.</param>
		public void SetSprites( Sprite[] sprites)
		{
			this.sprites = sprites;
		}
	
		// Use this for initialization
		void Start () {
	
		}
		
		public int GetTile()
		{
			return tile;
		}
		
		public void SetTile(int index)
		{
			tile = index;
			GetComponent<SpriteRenderer>().sprite = sprites[index];
		}
		
		public void SetTile(int x, int y)
		{
			SetTile( x + y * tilegrid.TilesPerRow() );
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
