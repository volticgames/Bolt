
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Bolt.Timeline {
	public class CutsceneTimeline
	{
	
		private Dictionary<float, List<TimelineEvent>> timeline;
		private Dictionary<string, ActionGroup> events;
		public SceneManager parent;
		private float time = 0f;
	
		public CutsceneTimeline ()
		{
			timeline = new Dictionary<float, List<TimelineEvent>>();
			events = new Dictionary<string, ActionGroup>();		
		}
		
		public void Update()
		{
			time += Time.deltaTime;
			
			List<float> toRemove = new List<float>();
			
			foreach (KeyValuePair<float, List<TimelineEvent>> entry in timeline)
			{
				if (entry.Key <= time)
				{
					foreach (var action in entry.Value)
					{
						action.Trigger();
						action.timeline = null;
					}
					
					toRemove.Add(entry.Key);
				}
			}
			
			foreach (var key in toRemove)
			{
				timeline.Remove(key);
			}
		}
		
		protected void AddEvent(string key, ActionGroup group)
		{
			events[key] = group;
		}
		
		protected void AddToTimeline(float time, TimelineEvent timelineEvent)
		{
			List<TimelineEvent> actionList;
		
			if (!timeline.TryGetValue(time, out actionList))
			{
				timeline[time] = new List<TimelineEvent>();
			}
			
			timeline[time].Add( timelineEvent );
			timelineEvent.timeline = this;
		}
		
		public void TriggerEvent(string name)
		{
			events[name].timeline = this;
			parent.StartCoroutine( events[name].Routine() );
		}
		
		public Coroutine StartCoroutine( IEnumerator routine )
		{
			return parent.StartCoroutine( routine );
		}
		
		public void Run( ActionGroup group )
		{
			group.timeline = this;
			parent.StartCoroutine( group.Routine() );
		}
		
	}
}

