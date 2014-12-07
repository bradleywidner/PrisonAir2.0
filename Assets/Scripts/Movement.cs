using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour 
{
    const int FORWARD = 0;
    const int BACKWARD = 1;
    const int LEFT = 2;
    const int RIGHT = 3;
	public float colorfloat = 0.5f;
	private bool AisPressed = false;
	private bool DisPressed = false;
    //public GameObject InvisibleColliders;

    //public BoxCollider StopsForce;
    //public BoxCollider ReverseArm;
    //public BoxCollider ArmStopper;
    //public BoxCollider HoldArmUp;

    private Vector3 MovementSpeedMax;
    public GameObject catapultMarker;
	public Transform spawnPoint;

    //public GameObject TargetForward;
    //public GameObject TargetBackward;

	float RotateValueInYAxis;
	float RotateValueInYAxisForSpawnPoint;
    
    public float MovementSpeed = 5;
    public int RotationSpeed = 10;

   //bool Turning = false; // Later
   //bool Moving = false; // Later
	void Start()
	{

	}
	public void Aclicked()
	{
		AisPressed = true;
	}
	public void Dclicked()
	{
		DisPressed = true;
	}
	public void AUnclicked()
	{
		AisPressed = false;
	}
	public void DUnclicked()
	{
		DisPressed = false;
	}

	void Update () 
    {
		// DO NOT EVER DELETE THIS
		RotateValueInYAxis = catapultMarker.transform.rotation.y; //Current Rotation of Object 
		spawnPoint.transform.rotation = new Quaternion(spawnPoint.transform.rotation.x,
		                                               RotateValueInYAxis,
		                                               spawnPoint.transform.rotation.z,
		                                               spawnPoint.transform.rotation.w);
		RotateValueInYAxisForSpawnPoint = spawnPoint.rotation.y;
		// DO NOT EVER DELETE THIS
      
		if (Input.GetKey("a") || AisPressed == true) // Turn Catapault Left 
        {
            Turn(1);
			colorSwap("Green", "InputAButton");

        }
		else if (Input.GetKey("d")|| DisPressed == true) // Turn Catapault Right
        {            
            Turn(2);
			colorSwap("Green", "InputDButton");
        }
		if(Input.GetKeyUp("a")|| AisPressed == true)
		{
			colorSwap("Grey", "InputAButton");
		}
		else if(Input.GetKeyUp("d")|| DisPressed == true)
		{
			colorSwap("Grey", "InputDButton");
		}
	}

	public void colorSwap(string couler, string buttonName)
	{
		Button aButton = GameObject.Find(buttonName).GetComponent<Button>();
	 	
		//aButton.normalColor = couler;
		if(couler.Equals ("Grey"))
		{
			aButton.image.color = Color.white;
			aButton.image.canvasRenderer.SetAlpha(0.5f);
		}
		else if(couler.Equals ("Green"))
		{
			aButton.image.color = Color.white;
			aButton.image.canvasRenderer.SetAlpha(1f);
		}

		//aButton.normalColor.a = new Color(0.5f,aButton.normalColor.r,aButton.normalColor.g,aButton.normalColor.b);
		//Debug.Log (colorfloat);
		//GameObject.Find(buttonName).GetComponent<Button>().colors.normalColor.a = opacity;
	}
    public void Move(int Direction)
    {
        //rigidbody.velocity = MovementSpeedMax;
       // Vector3 DIR;
        /*InvisibleColliders.transform.position = new Vector3(Catapult.transform.position.x,
                                                                    (float)(Catapult.transform.position.y - 0.9),
                                                                    (float)(Catapult.transform.position.z + 0.02));*/
//        switch(Direction)
//        {
//            case FORWARD:
//                //DIR = (TargetForward.transform.position - transform.position).normalized;
//                //Catapult.rigidbody.MovePosition(transform.position + DIR * MovementSpeed * Time.deltaTime);
//				catapultMarker.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime );
//                //Catapult.rigidbody.AddForce(transform.forward * MovementSpeed);
//                //TransformCollidersOnMove();
//                break;
//            case BACKWARD:
//				catapultMarker.transform.Translate(Vector3.forward * -1  * MovementSpeed * Time.deltaTime);
//                //Catapult.rigidbody.AddForce(transform.forward * -1 * MovementSpeed);
//                //DIR = (TargetBackward.transform.position - transform.position).normalized;
//                //Catapult.rigidbody.MovePosition(transform.position + DIR * MovementSpeed * Time.deltaTime);
//                //TransformCollidersOnMove();
//                break;
//        }
    }
    public void Turn(int Direction)
    {
		//Debug.Log("Marker: " + RotateValueInYAxis);
		//Debug.Log ("Spawn Point: " + RotateValueInYAxisForSpawnPoint);
        switch (Direction)
        {
            case 1:
                if (RotateValueInYAxis >= -0.3)
                {
                    catapultMarker.transform.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
                }
				if (RotateValueInYAxisForSpawnPoint >= -0.3)
				{
					spawnPoint.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
				}
                break;
            case 2:
                if (RotateValueInYAxis <= 0.3)
                {
                    catapultMarker.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
					spawnPoint.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
                }
				if (RotateValueInYAxisForSpawnPoint <= 0.3)
				{
					spawnPoint.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
				}
                break;
        }
    }

    /*
    void TransformCollidersOnMove()
    {
        StopsForce.transform.position =
            new Vector3((float)(Catapult.transform.position.x - 25.4),
                        (float)(Catapult.transform.position.y - 1.6),
                        (float)(Catapult.transform.position.z - 8.28));

        ReverseArm.transform.position =
             new Vector3((float)(Catapult.transform.position.x - 25.7),
                        (float)(Catapult.transform.position.y + 10.6),
                        (float)(Catapult.transform.position.z + 3.52));
        ArmStopper.transform.position =
           new Vector3((float)(Catapult.transform.position.x - 25.3),
                        (float)(Catapult.transform.position.y + 10.5),
                        (float)(Catapult.transform.position.z + 4.02));
        HoldArmUp.transform.position =
            new Vector3((float)(Catapult.transform.position.x - 25.4),
                        (float)(Catapult.transform.position.y - 1.8),
                        (float)(Catapult.transform.position.z - 8.28));
    }
    void TransformCollidersOnTurn(string UpOrDown)
    {
        if(UpOrDown.Equals("Up"))
        {
            StopsForce.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
            ReverseArm.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
            ArmStopper.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
            HoldArmUp.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
        }
        else
        {
            StopsForce.transform.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
            ReverseArm.transform.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
            ArmStopper.transform.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
            HoldArmUp.transform.Rotate(Vector3.down * (RotationSpeed * Time.deltaTime));
        }
    }*/
}
