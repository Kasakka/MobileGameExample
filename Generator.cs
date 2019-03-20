using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public GameObject cube;
	public int numberOfCubes;
	public int xmin,xmax;
	public int zmin,zmax;
	// Use this for initialization
	void Start () {
		PlaceCubes();
	}

	void PlaceCubes()
	{
		for(int i = 0; i < numberOfCubes; i++)
		{
			Instantiate(cube, GeneratedPosition(), Quaternion.identity);
		}
	}

	Vector3 GeneratedPosition()
	{
		int x,y,z;
		x = Random.Range(xmin,xmax);
		y = 0;
		z = Random.Range(zmin,zmax);
		return new Vector3(x,y,z);
	}
}
