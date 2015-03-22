using UnityEngine;
using System.Collections;

public class GameManager : SingletonSceneLifetime < GameManager > 
{

	// Use this for initialization
	void Start () 
	{
		BallPanel.Instance.Close ();
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 position = Vector3.zero;
		bool touchDetected = false;

		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log("BUTTON 0 DOWN");
			touchDetected = true;
			position = Input.mousePosition;
		} 
		else if (Input.touches.Length > 0 && Input.GetTouch(0).phase == TouchPhase.Began) 
		{
			Debug.Log("TOUCH START");
			touchDetected = true;
			position = Input.GetTouch(0).position;
		}

		if (touchDetected) 
		{
			Ray ray = Camera.main.ScreenPointToRay (position);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 200))
			{
				Transform t = hit.transform;
				Debug.Log("Ray hit "+t.gameObject.name); 

				Ball ball = t.gameObject.GetComponent< Ball >();
				if (ball != null)
				{
					BallPanel.Instance.Open(ball);
				}
			}          
		}
	}
}
