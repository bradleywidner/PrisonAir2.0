using UnityEngine;
using System.Collections;

public class PrisonAudio: MonoBehaviour {
	
	public AudioSource scream1;
	public AudioSource scream2;
	public AudioSource scream3;
	public AudioSource grunt1;
	public AudioSource grunt2;
	public AudioSource grunt3;
	public AudioSource splash;
	
	private int randomNumber;
	
	// Use this for initialization
	void Start () {
		
		randomNumber = (int)((Random.Range(1,3)));
		
		
		if(randomNumber == 1)
		{
			scream1.enabled = true;
		}
		if(randomNumber == 2)
		{
			scream2.enabled = true;
		}
		if(randomNumber == 3)
		{
			scream3.enabled = true;
		}			
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (randomNumber);
		
	}
	public void OnTriggerEnter(Collider Splash)
	{
		if(Splash.tag == "Water")
		{
			splash.enabled = true;
		}
	}
	public void OnCollisionEnter(Collision collider)
	{

		if(!(collider.gameObject.name.Contains("L_Hips")||
		     collider.gameObject.name.Contains("R_Knee")||
		     collider.gameObject.name.Contains("L_Elbow")||
		     collider.gameObject.name.Contains("Hips")||
		     collider.gameObject.name.Contains("Knee")||
		     collider.gameObject.name.Contains("Elbow")||
		     collider.gameObject.name.Contains("Arm")||
		     collider.gameObject.name.Contains("R_Elbow")))
		{
			//Debug.Log (collider.gameObject);
			if(randomNumber == 1)
			{
				grunt1.enabled = true;
				Debug.Log("Grunt 1 True");
			}
			if(randomNumber == 2)
			{
				grunt2.enabled = true;
				Debug.Log("Grunt 2 True");
			}
			if(randomNumber == 3)
			{
				grunt3.enabled = true;
				Debug.Log("Grunt 3 True");
			}
		}
	}
}