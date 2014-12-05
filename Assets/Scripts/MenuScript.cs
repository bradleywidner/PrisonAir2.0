using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {



	public void MenuSwitch(string level)
	{
		Application.LoadLevel(level);
	}
	public void Quit()
	{
		Application.Quit();
	}
}
