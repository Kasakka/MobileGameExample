using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSpawn : MonoBehaviour {
	public GameObject player;
	Vector3 SpawnPoint;
	private float screenWidth;
	private float screenHeight;
	public static float ScrollValue;
	public Slider slider;
	public Canvas canvas;
	float screenRatio;
	public Slider touchSensitivity;
	public static float sensitivity = 3f;


	// Use this for initialization
	void Start () {

		SpawnPoint = new Vector3(4.5f,-11.7f,4);
		Instantiate(player, SpawnPoint, Quaternion.AngleAxis(270, Vector3.right));
		getScreen();
	}
	
	// Update is called once per frame
	void Update () {
		sensitivity = touchSensitivity.value;
		ScrollValue = slider.value;
		foreach(Touch touch in Input.touches){

			if(touch.phase != TouchPhase.Ended){
				slider.value += touch.deltaPosition.x * (Time.deltaTime * sensitivity);
				//slider.value += (touch.position.x / screenWidth) * Time.deltaTime;
			}
		}

	}

	void OnGUI () {
		GUI.skin.horizontalScrollbar.fixedHeight = screenHeight;
		GUI.skin.horizontalScrollbarThumb.fixedHeight = screenHeight;

		if(GUI.Button(new Rect(10,10,60,40), "RESET")){
			Application.LoadLevel(0);
			staticReset();
		}
		if(GUI.Button(new Rect(10,80,60,40), "QUIT")){
			Application.Quit();
			staticReset();
		}

	}

	public Vector2 TouchDelta(Touch at){
		float dt = Time.deltaTime / at.deltaTime;
		if(float.IsNaN(dt) || float.IsInfinity(dt)){
			dt = 1.0f;
		}
		return at.deltaPosition * dt;
	}

	void getScreen(){
		screenWidth =  Screen.width;
		screenHeight = Screen.height;
		screenRatio = screenWidth / screenHeight;
	}

	void Awake(){
		DontDestroyOnLoad (touchSensitivity);
	}

	void staticReset(){
		RandomWall.kerroin = 2.5f;
		Movement.counter = 0;
		Destroyer.movement = true;
		Movement.wallCount = 0;
		PlayerControl.Vasen = false;
		PlayerControl.Oikea = false;
		PlayerControl.Idle = false;
		Destroyer.IsDestoyed = false;
		RandomWall.reikäKerroin = 0f;
		Movement.combiX = 16f;
		Movement.vasX = 2f;
		Movement.oikX = 14f;
	}
}
