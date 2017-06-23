using UnityEngine;
using System.Collections;

public class ScaleSphere : MonoBehaviour {

	[SerializeField] float sizeX = 1;
	[SerializeField] float sizeY = 2;
	[SerializeField] float sizeZ = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (sizeX, sizeY, sizeZ);
	}
}
