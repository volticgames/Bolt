using UnityEngine;
using System.Collections.Generic;
using Util;
using Bolt.Animation;

[RequireComponent (typeof (SpriteRenderer))]
public class SpriteAnimator : MonoBehaviour {

	public List<AddedAnimation> anims;
	public float speed = 0;
	public bool loop = false;
	private SpriteCollection frames;
	private float ticker;
	private int currentFrame;

	public string initialAnimation;
	public AddedAnimation currentAnimation;

	// Use this for initialization
	void Start () {
	
		Play(initialAnimation);
	
	}
	
	private void SetSprite(Sprite sprite)
	{
		GetComponent<SpriteRenderer>().sprite = sprite;
	}
	
	/// <summary>
	/// Get the animation object by name.
	/// </summary>
	/// <returns>The animation by name.</returns>
	/// <param name="name">Name.</param>
	private AddedAnimation GetAnimationByName(string name)
	{
		foreach (var anim in anims)
		{
			if (anim.GetName() == name)
			{
				return anim;
			}
		}
		
		return null;
	}
	
	/// <summary>
	/// Play an animation by name.
	/// </summary>
	/// <param name="animation">Animation.</param>
	public void Play(string animation)
	{
		currentAnimation = GetAnimationByName( animation );
		frames = new SpriteCollection(animation);
		SetSprite( frames.GetSpriteByIndex(0) );
		speed = GetAnimationByName( animation ).speed;
		loop = GetAnimationByName( animation ).loop;
	}
	
	/// <summary>
	/// Play an animation by the index.
	/// </summary>
	/// <param name="index">Index.</param>
	public void PlayIndex(int index)
	{
		currentAnimation = anims[index];
		frames = new SpriteCollection( anims[index].GetName() );
		SetSprite( frames.GetSpriteByIndex(0) );
		speed = anims[index].speed;
		loop = anims[index].loop;
	}
	
	// Update is called once per frame
	void Update () {
		ticker += Time.deltaTime;
		
		if (ticker > 1/speed)
		{
			currentFrame++;
			ticker = 0;
		}
		
		if (currentFrame >= frames.SpriteCount() && loop )
		{
			currentFrame = 0;
		} else if ( currentFrame >= frames.SpriteCount() ) {
			currentFrame--;
		}
		
		SetSprite( frames.GetSpriteByIndex( currentFrame ) );
	}
}
