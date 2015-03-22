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
	
		if (Input.GetMouseButton (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
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
