using UnityEngine;
using System.Collections;

namespace Bolt {
	public class TileGrid : MonoBehaviour {
	
		public int width;
		public int height;
		public int tileWidth;
		public int tileHeight;
		private GameObject tilePrefab;
		private Sprite[] sprites;
		public Texture2D tileset;
	
		// Happens before Start, make sure we're ready to load
		void Awake () {
		
			tilePrefab = Resources.Load<GameObject>("Prefabs/Tile");
			sprites = Resources.LoadAll<Sprite>(tileset.name);
	
		}
		
		/// <summary>
		/// Load a 2D array representing the tiles that this map should display.
		/// </summary>
		/// <param name="tiles">Tiles.</param>
		public void LoadTiles( int[,] tiles )
		{
		
			width = tiles.GetLength(0);
			height = tiles.GetLength(1);
			
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{			
					GameObject tile = Instantiate(tilePrefab) as GameObject;
					
					tile.transform.parent = this.transform;
					
					tile.GetComponent<Tile>().SetSprites( sprites );
					tile.GetComponent<Tile>().SetTile( tiles[j, i] );
					
					tile.transform.localPosition = new Vector3(i * tile.GetComponent<Renderer>().bounds.size.x, -1 * j * tile.GetComponent<Renderer>().bounds.size.y, 0);
				}
			}
		}
		
		public void SetTileSprites(Tile tile)
		{
			tile.SetSprites( sprites );
		}
		
		/// <summary>
		/// How many tiles are in each row of the tileset?
		/// </summary>
		/// <returns>The per row.</returns>
		public int TilesPerRow()
		{
			return tileset.width / tileWidth;
		}
	                     
		// Update is called once per frame
		void Update () {
	
		}
	}
}
