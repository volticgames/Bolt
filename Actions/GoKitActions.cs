using UnityEngine;
using System;
using System.Collections;

namespace Bolt.Actions
{
	public class GoKitActions
	{
		private GoKitActions ()
		{
		}
		
		public static IEnumerator MoveTo(GameObject obj, Vector3 destination, float duration, GoEaseType ease = GoEaseType.Linear, bool waitForCompletion = false)
		{	
			var tween = Go.to ( obj.transform, duration, new GoTweenConfig()
													.position( destination )
													.setEaseType( ease )
						);
			
			if (waitForCompletion)
			{
				yield return WaitForTweenComplete( tween );
			} else {
				yield return null;
			}
		}
		
		
		
		public static WaitForSeconds WaitForTweenComplete( GoTween tween )
		{
			return new WaitForSeconds( tween.duration );
		}
	}
}

