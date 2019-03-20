using UnityEngine;
using System.Collections;

public class Colorizer : MonoBehaviour {

	public GameObject target;
	public Color colorStart;
	public Color colorEnd;
	public float speed = 2f;
	Color myColor1;
	Color myColor2;

	// Use this for initialization
	void Start () {
		Colors1 ();
		Colors2 ();
	}
	
	// Update is called once per frame
	void Update () {

		colorStart = GetComponent<Light>().color;
		colorEnd = myColor2;
		GetComponent<Light>().color = Color.Lerp(colorStart, colorEnd, Time.deltaTime / speed);

		if(Movement.wallCount == 10){
			Colors2();
			Movement.wallCount = 0;
		}

		if (GetComponent<Light>().color == colorEnd)
			Colors2();

	}

	void Colors1(){
		bool mode = Random.value > 0.5f;
		float rand = Random.value;
		int index = Random.Range( 0, 3 );
		myColor1[index] = rand;
		myColor1[( index + ( mode ? 1 : 2 ) ) % 3] = 1;
		myColor1[( index + ( mode ? 2 : 1 ) ) % 3] = 0;
	}

	void Colors2(){
		bool mode = Random.value > 0.5f;
		float rand = Random.value;
		int index = Random.Range( 0, 3 );
		
		myColor2[index] = rand;
		myColor2[( index + ( mode ? 2 : 1 ) ) % 3] = 0;
		myColor2[( index + ( mode ? 1 : 2 ) ) % 3] = 1;
	}

}
