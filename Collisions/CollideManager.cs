using UnityEngine;
using System.Collections;
using Eppy;
using Util;
using System.Linq;

public class CollideManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Tuple<GameObject, Hitbox> Collide(string type, Hitbox collider ) {
		return CollideAt (new string[] {type}, collider, collider.transform.position.x, collider.transform.position.y);
	}
	
	public Tuple<GameObject, Hitbox> Collide(string[] types, Hitbox collider ) {
		return CollideAt (types, collider, collider.transform.position.x, collider.transform.position.y);
	}

	public Tuple<GameObject, Hitbox> CollideAt( string[] types, Hitbox collider, float x, float y )
	{
		
		var collisionList = Object.FindObjectsOfType<Hitbox> ();

		foreach (Hitbox hb in collisionList)
		{
			if (hb != collider && types.Contains(hb.type))
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
