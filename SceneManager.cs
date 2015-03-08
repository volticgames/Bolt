using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	
	public CutsceneTimeline timeline;
	
	// Use this for initialization
	void Start () {
		
		SetTimeline( new TestTimeline() );
	}
	
	public SceneManager() : base()
	{
	
	}
	
	public void SetTimeline(CutsceneTimeline timeline)
	{
		if (this.timeline != null)
		{
			this.timeline.parent = null;
		}
		
		this.timeline = timeline;
		this.timeline.parent = this;
	}
	
	// Update is called once per frame
	void Update () {
		timeline.Update();
	}
}
