using UnityEngine;
using System.Collections;
using Bolt.Util;
using Bolt.Collisions;

namespace Bolt {
	
	public class PlatformMovement : MonoBehaviour {
		
		public Vector2 velocity;
		
		public Vector2 maxSpeed;
		public float gravity;
		
		public string[] collideTypes;
		
		// Use this for initialization
		void Start () {
			velocity.x = velocity.y = 0;
		}
		
		// Update is called once per frame
		void Update () {
			velocity.y -= gravity;
			
			velocity.x = ClampUtil.Clamp (velocity.x, -1 * maxSpeed.x, maxSpeed.x);
			velocity.y = ClampUtil.Clamp (velocity.y, -1 * maxSpeed.y, maxSpeed.y);
			
			var pos = this.transform.position;
			
			var scaledVelocity = new Vector2 (velocity.x * TimeUtil.scale (),
			                                  velocity.y * TimeUtil.scale ());
			
			if (velocity.x != 0)
			{
				var collision = CollideManager.CollideAt (collideTypes, this.GetComponent<Hitbox> (), scaledVelocity.x, 0);
				
				if (collision == null)
				{
					pos.x += scaledVelocity.x;
				} else {
					
					velocity.x = 0;
					
					var hitbox = this.GetComponent<Hitbox> ();
					
					if (hitbox.xLeft < collision.second.xLeft)
					{
						pos.x = collision.second.xLeft - hitbox.width - hitbox.offsetX;
					} else {
						pos.x = collision.second.xRight  - hitbox.offsetX;
					}
				}
			}
			
			if (velocity.y != 0)
			{
				var collision = CollideManager.CollideAt (collideTypes, this.GetComponent<Hitbox> (), 0, scaledVelocity.y);
				
				if (collision == null)
				{
					pos.y += scaledVelocity.y;
				} else {
					
					velocity.y = 0;
					
					var hitbox = this.GetComponent<Hitbox> ();
					
					if (hitbox.yBottom < collision.second.yBottom)
					{
						pos.y = collision.second.yBottom - hitbox.offsetY;
					} else {
						pos.y = collision.second.yTop + hitbox.height - hitbox.offsetY;
					}
					
				}
			}
			
			this.transform.position = pos;
		}
		
		public bool OnGround()
		{
			var collision = CollideManager.CollideAt (collideTypes, this.GetComponent<Hitbox> (), 0, -0.5f);
			
			return collision != null;
		}
	}
}

