using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class Player : MonoBehaviour 
{
	public Vector3 inputValue;

	void Update()
	{
		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");
	
		transform.Translate (inputValue);
	}
}
