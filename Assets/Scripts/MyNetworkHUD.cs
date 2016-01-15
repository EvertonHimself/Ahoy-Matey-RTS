using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/// <summary>
/// My network HUD.
/// </summary>
public class MyNetworkHUD : NetworkManager 
{
//	private NetworkManager networkManager;

	void Start()
	{
//		networkManager = GetComponent<NetworkManager>();
	}

	/// <summary>
	/// My start host method.
	/// </summary>
	public override void StartHost()
	{
//		networkManager.StartHost();
		Debug.Log ("Starting host at: " + Time.timeSinceLevelLoad);
	}

	/// <summary>
	/// Raises the start host event.
	/// </summary>
	public override void OnStartHost()
	{
		Debug.Log ("Host started at (OnStartHost): " + Time.timeSinceLevelLoad);
	}
}
