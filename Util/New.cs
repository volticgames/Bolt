using UnityEngine;
using System.Collections;

public class New {

	// Use this for initialization
	public static GameObject GameObject (string name) {
		var obj = Object.Instantiate( Resources.Load(name) as GameObject );
		
		return obj;
	}
	
	public static GameObject GameObject (GameObject template) {
		var obj = Object.Instantiate( template );
		return obj;
	}
	
	public static GameObject GameObject(string name, GameObject parent) {
		var go = GameObject(name);
		
		go.transform.parent = parent.transform;
		
		return go;
	}
	
	public static GameObject GameObject(string name, Transform parent) {
		var go = GameObject(name);
		
		go.transform.parent = parent;
		
		return go;
	}
	
	public static GameObject GameObject(GameObject template, GameObject parent) {
		var go = GameObject(template);
		
		go.transform.parent = parent.transform;
		
		return go;
	}
	
	public static GameObject GameObject(GameObject template, Transform parent) {
		var go = GameObject(template);
		
		go.transform.parent = parent;
		
		return go;
	}
}
