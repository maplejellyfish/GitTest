using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	[SerializeField] float rotateSpeed = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.right, Time.deltaTime * rotateSpeed);
	}
}
