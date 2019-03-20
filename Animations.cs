using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {
	
	public Animator ButtonReset;
	public Animator ButtonExit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Destroyer.IsDestoyed == true){
			//ButtonReset.SetBool("IsDestroyed", true);
			//ButtonExit.SetBool("IsDestroyed", true);
		}
	
	}
}
