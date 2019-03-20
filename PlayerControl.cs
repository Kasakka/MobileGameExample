using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject player;
	Animator anim;
	public float speed = 50f;
	Vector3 currentPos;
	public static bool Vasen = false;
	public static bool Oikea = false;
	public static bool Idle = true;
	Quaternion currenRot;
	float AccUpdateInt = 1.0f/60.0f;
	float LowPassKernel = 3.0f;
	Vector3 LowPassValue = Vector3.zero;
	float LowPassFilter;


	// Use this for initialization
	void Start () {
		LowPassValue = Input.acceleration;
		LowPassFilter = AccUpdateInt / LowPassKernel;
		anim = this.GetComponent<Animator>();
		currentPos = player.transform.position;
		currenRot = player.transform.localRotation;
		transform.position = new Vector3(PlayerSpawn.ScrollValue +0.8f,-11.7f,4);

	}
	
	// Update is called once per frame
	void Update () {

		/*if(transform.position.x < -1.8f)
			transform.position = new Vector3(-1.7f,-11.7f,4);
		if(transform.position.x > 11.1f)
			transform.position = new Vector3(11.0f,-11.7f,4);*/

		transform.position = new Vector3(PlayerSpawn.ScrollValue +0.8f,-11.7f,4);
		//transform.Translate(LowPassFilterAccel().x, 0, 0);

		Vector3 direction = player.transform.position - currentPos;

		currenRot = player.transform.localRotation;
		//player.transform.Rotate(Vector3.forward * Time.deltaTime *10);
		//while(Vasen == true)
		//player.transform.Rotate(new Vector3(0, player.transform.localRotation.y + 1, player.transform.localRotation.z + 1) * Time.deltaTime *500);

		if(currentPos.x > player.transform.position.x){
			Vasen = true;
			Oikea = false;
			Idle = false;

		}
		else if(currentPos.x < player.transform.position.x){
			Vasen = false;
			Oikea = true;
			Idle = false;
		}
		else
			Idle = true;

		currentPos = player.transform.position;
	}

	Vector3 LowPassFilterAccel(){
		LowPassValue = Vector3.Lerp(LowPassValue, Input.acceleration, LowPassFilter);
		return LowPassValue;
	}

}
