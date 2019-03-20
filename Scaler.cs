using UnityEngine;
using System.Collections;

public class Scaler : MonoBehaviour {

	public GameObject obstacle;
	private Vector3 startScale = new Vector3(0.1f,0.1f,0.1f);
	private Vector3 endScale = new Vector3(1,1,1);
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(0.1f,0.1f,0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		if(obstacle.transform.localScale == startScale)
			scaler();
		else
			obstacle.transform.localScale = endScale;
	}

	void scaler(){
		obstacle.transform.localScale = Vector3.Lerp(startScale, endScale, speed * Time.deltaTime);
	}
}
