using UnityEngine;
using System.Collections;

public class LimbCollider : MonoBehaviour 
{
	bool HasCollided = false;
	string TagObjectHit = "";
	string LimbName;

	void Start()
	{
		LimbName = gameObject.name;
	}
	void OnCollisionEnter(Collision Collision)
	{
		if(!(Collision.gameObject.name.Contains("L_Hips")||
		     Collision.gameObject.name.Contains("R_Knee")||
		     Collision.gameObject.name.Contains("L_Elbow")||
		     Collision.gameObject.name.Contains("R_Hips")||
		     Collision.gameObject.name.Contains("L_Knee")||
		     Collision.gameObject.name.Contains("L_Elbow")||
		     Collision.gameObject.name.Contains("R_Elbow"))&&

		   	(Collision.gameObject.tag.Contains("BowlingPin")||
			 Collision.gameObject.tag.Contains("Blimp")||
			 Collision.gameObject.tag.Contains("Spikes")||
			 Collision.gameObject.tag.Contains("Toilet")||
			 Collision.gameObject.tag.Contains("Spotlight")||
			 Collision.gameObject.tag.Contains("FireRing")||
			 Collision.gameObject.tag.Contains("Tower")||
		 	 Collision.gameObject.tag.Contains("MegaBowlingPin")||
			 Collision.gameObject.tag.Contains("RopeSoap")||
			 Collision.gameObject.tag.Contains("PrisonBars")||
			 Collision.gameObject.tag.Contains("WashingMachine")||
			 Collision.gameObject.tag.Contains("BenchPressBar")||
		 	 Collision.gameObject.tag.Contains("PrisonAlarm")||
		     Collision.gameObject.tag.Contains("Wall")||
		   	 Collision.gameObject.tag.Contains("Terrain")||
		 	 Collision.gameObject.tag.Contains("FrontWall")||
			 Collision.gameObject.tag.Contains("Catapult")||
		     Collision.gameObject.tag.Contains ("Bolt")||
		     Collision.gameObject.tag.Contains("PRISON_FLOOR")))
			{
					//Debug.Log (gameObject.name + "Collided With:" + Collision.gameObject.name);
					HasCollided = true;
					TagObjectHit = Collision.gameObject.tag;
			}
	}
	public bool HasLimbCollided()
	{
		return HasCollided;
	}
	public void SetHasCollided(bool Collided)
	{
		HasCollided = Collided;
	}
	public string GetTagOfObjectHit()
	{
		return TagObjectHit;
	}
	public string GetLimbName()
	{
		return LimbName;
	}
}
