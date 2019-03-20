using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	GameObject[] musicObject;
	GameObject[] pommi;
	public AudioClip audio1;
	public AudioClip audio2;
	public AudioClip audio3;
	public AudioClip audio4;
	int random;
	
	// Use this for initialization
	void Start () {
		random = Mathf.RoundToInt(Random.Range(0,4));
		musicObject = GameObject.FindGameObjectsWithTag ("Music");
		if (musicObject.Length == 1 ) {
			if(random == 0){
				GetComponent<AudioSource>().clip = audio1;
				GetComponent<AudioSource>().Play ();

			}
			if(random == 1){
				GetComponent<AudioSource>().clip = audio2;
				GetComponent<AudioSource>().Play ();

			}
			if(random == 2){
				GetComponent<AudioSource>().clip = audio3;
				GetComponent<AudioSource>().Play ();

			}
			if(random == 3){
				GetComponent<AudioSource>().clip = audio4;
				GetComponent<AudioSource>().Play ();
				
			}
		} 
		else {
			for(int i = 1; i < musicObject.Length; i++){
				Destroy(musicObject[i]);

			}
		}
	}
	
	// Update is called once per frame
	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}
	void Update(){
		if(GetComponent<AudioSource>().isPlaying == false){
			random = Mathf.RoundToInt(Random.Range(0,3));
		}
	}
}
