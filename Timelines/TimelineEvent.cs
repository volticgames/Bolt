
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TimelineEvent
{
	
	private string eventToTrigger;
	private ActionGroup groupToRun;
	private Func<IEnumerator> methodToCall;
	public CutsceneTimeline timeline;
	
	public TimelineEvent (string eventToTrigger)
	{
		this.eventToTrigger = eventToTrigger;
	}
	
	public TimelineEvent(ActionGroup groupToRun)
	{
		this.groupToRun = groupToRun;
	}
	
	public TimelineEvent(Func<IEnumerator> action )
	{
		methodToCall = action;	
	}
	
	public Coroutine StartCoroutine(IEnumerator routine)
	{
		return timeline.StartCoroutine( routine );
	}
	
	public void Trigger()
	{
		if (groupToRun != null)
		{
			timeline.Run( groupToRun );
		} else if (eventToTrigger != null) {
			timeline.TriggerEvent( eventToTrigger );
		} else {
			timeline.Run( methodToCall );
		}
	}
	
}


