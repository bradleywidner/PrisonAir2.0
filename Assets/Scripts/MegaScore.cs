using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MegaScore : MonoBehaviour 
{
	const int MULTIPLER_TEXT = 		22;
	public Text doubleScore;
	//public Text onABoat;

	//public Collider onABoatCollider;
	private float timer = 3.0f;
	private bool reset = false;

	private GameObject Cop;
	private Cop CopSetup;
	void Start()
	{
		Cop = GameObject.Find("Cop");
		CopSetup = (Cop)Cop.GetComponent(typeof(Cop));
		doubleScore.enabled = false;
	}
	void Update()
	{
		if(reset == true)
		{
			timer -= Time.deltaTime;
			if(timer <= 0)
			{
				doubleScore.enabled = false;
				//onABoat.enabled = false;
				reset = false;
				timer = 3f;
			}
		}
	}	

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{	
			CopSetup.SetTotalScore(CopSetup.GetTotalScore() * 2);

			PrisonObstacle PrisonObstacle = gameObject.GetComponent<PrisonObstacle>();
			PrisonObstacle.scorehitCount[MULTIPLER_TEXT] += 1;

			Debug.Log ("Multipler text has: " + PrisonObstacle.scorehitCount[MULTIPLER_TEXT]);

			doubleScore.enabled = true;
			reset = true;
		}
	}
}
