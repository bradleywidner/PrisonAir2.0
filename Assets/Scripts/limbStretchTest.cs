using UnityEngine;
using System.Collections;

public class limbStretchTest : MonoBehaviour {
	private Vector3 startPosition;
	// Use this for initialization
	void Start () {

		startPosition = transform.localPosition;
		transform.localPosition = startPosition;
	}
	
	// Update is called once per frame
	void LateUpdate () {


	
	}
}
