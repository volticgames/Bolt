
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Bolt.Timeline {
	public class TimelineEvent
	{
		
		private string eventToTrigger;
		private ActionGroup groupToRun;
		public CutsceneTimeline timeline;
		
		public TimelineEvent (string eventToTrigger)
		{
			this.eventToTrigger = eventToTrigger;
		}
		
		public TimelineEvent(ActionGroup groupToRun)
		{
			this.groupToRun = groupToRun;
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
			} else {
				timeline.TriggerEvent( eventToTrigger );
			}
		}
		
	}
}


