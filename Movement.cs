using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject player;
	float kerroin2;
	bool movement;
	public static int wallCount;
	public static int counter;
	public static float vasX = 2f;
	public static float oikX = 14f;
	public static float combiX = 16f;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		movement = Destroyer.movement;
		kerroin2 = RandomWall.kerroin;
		Liikutus();
		Destroy();

	}

	public void Liikutus(){
		if(movement == true)
		transform.position += (new Vector3(0,0,-10) * Time.deltaTime) * kerroin2;
	}

	
	void Destroy(){
		if(gameObject.transform.position.z < player.transform.position.z - 3){
			Destroy(gameObject);
			wallCount++;
			counter++;

		if(combiX < 17.8f){
				combiX = (vasX + RandomWall.reikäKerroin)+(oikX + RandomWall.reikäKerroin);
				RandomWall.reikäKerroin += 0.0167f;
			}
		}
	}
}
