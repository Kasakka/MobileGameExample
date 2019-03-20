using UnityEngine;
using System.Collections;

public class RandomWall : MonoBehaviour {
	
	public GameObject obstacle;
	public Vector3 SpawnPoint;
	public float timer;
	public float waitTime;
	public static float kerroin = 2.5f;
	bool wallEasy = true;
	bool wallMedium = false;
	bool wallHard = false;
	int random;
	Color colorStart;
	Color colorEnd;
	GameObject clone;
	Renderer[] renderers;
	public static float reikäKerroin = 0f;



	void Start(){
		clone = InstantiateRandomScale(obstacle, 2, 14);
		//colorStart = obstacle.renderer.material.color;
	}
	void Update () {
		timer += Time.deltaTime;
		if(Movement.counter <= 30){
			wallEasy = true;
			wallMedium = false;
			wallHard = false;
		}
		/*if(Movement.counter > 30 && Movement.counter < 60){
			wallEasy = false;
			wallMedium = true;
			wallHard = false;
		}
		if(Movement.counter >= 60){
			wallEasy = false;
			wallMedium = false;
			wallHard = true;

		}*/
		if(Destroyer.movement == true)
		{
			if(timer > waitTime){

				timer = 0;
				kerroin += 0.1f;

				if(waitTime > 1f)
					waitTime -= 0.1f;
				else if(waitTime > 0.4f && waitTime <= 1f)
					waitTime -= 0.01f;
				/*else if(waitTime < 0.4f && Movement.counter < 90)
					waitTime = 0.4f;*/
				else if(Movement.counter > 90 && waitTime > 0.25f)
					waitTime -= 0.01f;
				else if(waitTime < 0.25f)
					waitTime = 0.25f;

				if(wallEasy == true){
					clone = InstantiateRandomScale(obstacle, Movement.vasX, Movement.oikX);
				}
				if(wallMedium == true){
					clone = InstantiateRandomScale(obstacle, 2.5f, 14.5f);
				}
				if(wallHard == true){
					clone = InstantiateRandomScale(obstacle, 2.8f, 14.8f);
				}
			}
		}
	}

	GameObject InstantiateRandomScale(GameObject source, float minScale, 
	                                  float maxScale)
	{
		SpawnPoint = new Vector3(7.7f, -9.8f, 92.8f);
		GameObject clone = Instantiate(source) as GameObject;
		if(wallEasy == true){
			clone.transform.Find("Vasen").localScale = new Vector3(1 * Random.Range(minScale, maxScale), 1, 1);
			clone.transform.Find("Oikea").localScale = new Vector3(Movement.combiX-clone.transform.Find("Vasen").localScale.x, 1, 1);
		}
		return clone;
	}
}