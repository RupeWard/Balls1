using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private BallSet ballSet_ = null;

	// Use this for initialization
	void Start () 
	{
	}

	public void Init(BallSet bs)
	{
		ballSet_ = bs;
		Material myMaterial = new Material (ballSet_.ballMaterial);
		GetComponent< MeshRenderer > ().material = myMaterial;
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}
