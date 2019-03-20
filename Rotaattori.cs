using UnityEngine;
using System.Collections;

public class Rotaattori : MonoBehaviour {

	float timer;
	float waitTime;
	public float speed = 50f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*timer += Time.deltaTime;
		waitTime = 15f;
		if(timer < waitTime)
			transform.Rotate(Vector3.up * Time.deltaTime);

		if(timer > waitTime)
			transform.Rotate(Vector3.down * Time.deltaTime);

		if(timer > waitTime * 2)
			timer = 0;*/
		
		if(PlayerControl.Vasen == true && Destroyer.movement == true && PlayerControl.Idle == false){
			transform.Rotate(Vector3.forward * Time.deltaTime * speed);
		}

		if(PlayerControl.Oikea == true && Destroyer.movement == true && PlayerControl.Idle == false){
			transform.Rotate(Vector3.back * Time.deltaTime * speed);
		}
	}

	void Rotation(){

	}
}
