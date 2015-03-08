using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject follow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = follow.transform.position;
		pos.z = -10;
		
		var current = this.transform.position;
		
		current.x -= ( this.transform.position.x - pos.x ) / 5.0f;
		current.y -= ( this.transform.position.y - pos.y ) / 5.0f;
		
		this.transform.position = current;
	}
}
