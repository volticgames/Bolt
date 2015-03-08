using UnityEngine;

public class Hitbox : MonoBehaviour {

	public float width;
	public float height;
	public float offsetX;
	public float offsetY;
	public string type = "solid";

	public float Width
	{
		get
		{
			return width;
		}
		set
		{
			width = value;
		}
	}
	
	public float Height
	{
		get
		{
			return height;
		}
		set
		{
			height = value;
		}
	}

	public float xLeft
	{
		get {
			return transform.position.x + offsetX;
		}
	}
	
	public float xRight
	{
		get {
			return transform.position.x + offsetX + width;
		}
	}
	
	public float yTop
	{
		get {
			return transform.position.y + offsetY;
		}
	}
	
	public float yBottom
	{
		get {
			return transform.position.y - height + offsetY;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	/// <summary>
	/// Does this Hitbox intersect with another one.
	/// </summary>
	/// <param name="hb">Hb.</param>
	/// <param name="xOff">X off.</param>
	/// <param name="yOff">Y off.</param>
	public bool Intersect(Hitbox hb, float xOff, float yOff)
	{
		if (xRight <= (hb.xLeft - xOff) || (hb.xRight - xOff) <= xLeft || yTop <= (hb.yBottom - yOff) || (hb.yTop - yOff) <= yBottom)
		{
			return false;
		} else {
			return true;
		}
	}

	public void OnDrawGizmos()
	{
		Gizmos.color = new Color (1f, 0f , 0f, 0.5f);
		Gizmos.DrawWireCube (new Vector3( transform.position.x + offsetX + width / 2, transform.position.y + offsetY - height / 2, transform.position.z),
		                 new Vector3 (width, height, 1));

		Gizmos.color = new Color (0f, 1f , 0f, 0.5f);
		Gizmos.DrawWireCube (transform.position,
		                     new Vector3 (5.0f, 5.0f, 1f));
		                     
		Gizmos.color = new Color (0f, 0f, 1f, 0.5f);
	}

	public Rect AsRect()
	{
		return new Rect (xLeft, yTop, width, height);
	}

}
