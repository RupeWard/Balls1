using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallPanel : SingletonSceneLifetime < BallPanel > 
{
	private Ball currentBall_ = null;
	public Text headingText;

	// Use this for initialization
	void Start () {
		Close ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetBall( Ball b)
	{
		currentBall_ = b;
		if (currentBall_ != null) 
		{
			headingText.text = b.gameObject.name;
		} 
		else 
		{
			headingText.text = "NONE";
		}
	}

	public void Open(Ball b)
	{
		SetBall (b);
		Open ();
	}

	public void Open()
	{
		gameObject.SetActive (true);
	}

	public void Close()
	{
		gameObject.SetActive (false);
	}
}
