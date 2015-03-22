using UnityEngine;
using System.Collections;

public class BallSet : MonoBehaviour {

	static int s_nextBallNumber = 0;

	public Transform ballSpawnPoint;
	public GameObject ballPrefab;
	public Transform ballsContainer;

	public Material ballMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnBall()
	{
		GameObject newObject = Instantiate (ballPrefab) as GameObject;
		newObject.name = "Ball" + s_nextBallNumber.ToString ();
		newObject.transform.position = ballSpawnPoint.transform.position;
		newObject.transform.parent = ballsContainer;

		Ball newBall = newObject.GetComponent< Ball > ();
		newBall.Init (this);

		s_nextBallNumber++;
	}
}
