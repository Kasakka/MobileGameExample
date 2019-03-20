using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = ""+Movement.counter;
		if(Movement.counter >= 10 && Movement.counter < 30){
			text.color = Color.Lerp(text.color, Color.blue, Time.deltaTime);

		}
		else if(Movement.counter >= 30 && Movement.counter < 60){
			text.color = Color.Lerp(text.color, Color.green, Time.deltaTime);

		}
		else if(Movement.counter >= 60 && Movement.counter < 90){
			text.color = Color.Lerp(text.color, Color.yellow, Time.deltaTime);

		}
		else if(Movement.counter >= 90){
			text.color = Color.Lerp(text.color, Color.red, Time.deltaTime);
			
		}
	}
}
