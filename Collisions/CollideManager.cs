using UnityEngine;
using System.Collections;
using Eppy;
using Bolt.Util;
using System.Linq;

namespace Bolt.Collisions {
	public class CollideManager {
	
		public static Tuple<GameObject, Hitbox> Collide(string type, Hitbox collider ) {
			return CollideAt (new string[] {type}, collider, collider.transform.position.x, collider.transform.position.y);
		}
		
		public static Tuple<GameObject, Hitbox> Collide(string[] types, Hitbox collider ) {
			return CollideAt (types, collider, collider.transform.position.x, collider.transform.position.y);
		}
		
		public static Tuple<GameObject, Hitbox> CollideAt( string type, Hitbox collider, float x, float y )
		{
			return CollideAt (new string[] {type}, collider, x, y);
		}
	
		public static Tuple<GameObject, Hitbox> CollideAt( string[] types, Hitbox collider, float x, float y )
		{
			
			var collisionList = Object.FindObjectsOfType<Hitbox> ();
	
			foreach (Hitbox hb in collisionList)
			{
				if (hb.isActive() && hb != collider && types.Contains(hb.type))
				{
					var intersect = collider.Intersect(hb, x, y);
					
					if (intersect)
					{
						return new Tuple<GameObject, Hitbox> (hb.gameObject, hb);
					}
				}
			}
			
			return null;
		}
	}
}
