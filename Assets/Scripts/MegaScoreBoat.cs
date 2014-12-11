using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MegaScoreBoat : MonoBehaviour 
{
	public Text onABoat;

	private float timer = 3.0f;
	private bool reset = false;
	
	private GameObject Cop;
	private Cop CopSetup;
	void Start()
	{

	}
	void Update()
	{
		if(reset == true)
		{
			timer -= Time.deltaTime;
			if(timer <= 0)
			{

				onABoat.enabled = false;
				reset = false;
				timer = 3f;
			}
		}
	}	
	
	private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player")
		{	
			onABoat.enabled = true;
			reset = true;
		}
	}
}