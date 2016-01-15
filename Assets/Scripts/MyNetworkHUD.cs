using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/// <summary>
/// My network HUD.
/// </summary>
public class MyNetworkHUD : MonoBehaviour 
{
	private NetworkManager networkManager;

	void Start()
	{
		networkManager = GetComponent<NetworkManager>();
	}

	/// <summary>
	/// My start host method.
	/// </summary>
	public void MyStartHost()
	{
		networkManager.StartHost();
		Debug.Log ("Starting host at " + Time.timeSinceLevelLoad);
	}

	/// <summary>
	/// Raises the start host event.
	/// </summary>
	void OnStartHost()
	{
		Debug.Log ("Host started at (OnStartHost)" + Time.timeSinceLevelLoad);
	}
}
