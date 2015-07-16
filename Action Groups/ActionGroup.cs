
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Bolt.Timeline;

namespace Bolt {
	public class ActionGroup
	{
		public CutsceneTimeline timeline;
		
		public ActionGroup ()
		{
			
		}
		
		protected Coroutine StartCoroutine( IEnumerator routine )
		{
			return timeline.StartCoroutine( routine );
		}
		
		public virtual IEnumerator Routine()
		{
			yield return null;
		}
	}
}