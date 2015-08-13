using UnityEngine;
using System.Collections;

namespace Bolt {
	public static class TransformExtensions {
		public static void SetLocalPosition(this Transform transform, float x = 0, float y = 0, float z = 0) {
			transform.localPosition = new Vector3(x, y, z);
		}
	}
}