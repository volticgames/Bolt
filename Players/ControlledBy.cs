using UnityEngine;
using System.Collections;

namespace Bolt.Control {
	public class ControlledBy : MonoBehaviour {
	
		public int playerIndex = 0;
		
		public Player GetPlayer()
		{
			return Players.players[playerIndex];
		}
	
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}