using UnityEngine;
using System.Collections;

public class BlimpMovement : MonoBehaviour {

	public GameObject Blimp;
	public Transform pivotPoint;
	private float speed = 20f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Blimp.transform.RotateAround(pivotPoint.position,Vector3.down, speed * Time.deltaTime);
	
	}
}
