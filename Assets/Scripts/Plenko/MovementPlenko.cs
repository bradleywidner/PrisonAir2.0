using UnityEngine;
using System.Collections;

public class MovementPlenko : MonoBehaviour {

	public Rigidbody character;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		character.constantForce.relativeForce = new Vector3(0f,150f,0f);

		if (Input.GetKey("a")) // Turn Catapault Left 
		{
			Turn("LEFT");

			
		}
		else if (Input.GetKey("d")) // Turn Catapault Right
		{            
			Turn("RIGHT");

		}
		else if (Input.GetKey("w")) // Turn Catapault Left 
		{
			Turn("UP");
		
			
		}
		else if (Input.GetKey("s")) // Turn Catapault Right
		{            
			Turn("DOWN");

		}
	}

	public void Turn(string direction)
	{
		if(direction.Contains("UP"))
		{
			character.AddForce(Vector3.up *10);
		}
		else if(direction.Contains("LEFT"))
		{
			character.AddForce(Vector3.left *100);
		}
		else if(direction.Contains("RIGHT"))
		{
			character.AddForce(Vector3.right *100);
		}
		else if(direction.Contains("DOWN"))
		{
			character.AddForce(Vector3.down *100);
		}
	}
}















