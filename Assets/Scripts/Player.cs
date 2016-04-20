using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class Player : NetworkBehaviour 
{
	public Vector3 inputValue;

	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}

		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");

		transform.Translate (inputValue);
	}

	/// <summary>
	/// Raises the start local player event.
	/// </summary>
	public override void OnStartLocalPlayer()
	{
		GetComponentInChildren<Camera>().enabled = true;
	}
}
