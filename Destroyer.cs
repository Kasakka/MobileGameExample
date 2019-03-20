using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour {
	
	public GameObject player;
	public static bool movement = true;
	public GameObject explosion;
	public AudioClip pommi;
	int hitCount;
	public static bool IsDestoyed = false;

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Seinä")

		{
			AudioSource.PlayClipAtPoint(pommi, new Vector3(5, -7.86f, -6.95f));
			Destroy(player);
			Instantiate(explosion, player.transform.position, Quaternion.identity);
			movement = false;
			hitCount++;
			IsDestoyed = true;
			Handheld.Vibrate();

		}

		if (hitCount < Movement.counter){
			hitCount = Movement.counter;
			Destroy(player);
			movement = false;
			IsDestoyed = true;
			Handheld.Vibrate();
		}
	}
}
