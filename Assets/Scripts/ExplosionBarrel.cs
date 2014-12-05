using UnityEngine;
using System.Collections;

public class ExplosionBarrel : MonoBehaviour {

	public Transform explosionPosition;
	public GameObject explosionEffect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision theplayer)
	{
		Debug.Log(theplayer.gameObject.name);
		if(theplayer.gameObject.name.Contains("MiddleSpine"))
		{
			Instantiate(explosionEffect,explosionPosition.position,explosionPosition.rotation);
			Debug.Log ("Entered");
			//theplayer.rigidbody.AddExplosionForce(4000f,new Vector3(explosionPosition.position.x,
		                                                           //explosionPosition.position.y,
		                                                           //explosionPosition.position.z),250f);
		}
	}
}
