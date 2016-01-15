using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/// <summary>
/// My network HUD.
/// </summary>
public class MyNetworkManager : NetworkManager 
{
//	private NetworkManager networkManager;

	void Start()
	{
//		networkManager = GetComponent<NetworkManager>();
	}

	/// <summary>
	/// My start host method.
	/// </summary>
	void MyStartHost()
	{
//		networkManager.StartHost();
		StartHost();
		Debug.Log (Time.timeSinceLevelLoad + " Starting host.");
	}

	/// <summary>
	/// Raises the start host event.
	/// </summary>
	public override void OnStartHost()
	{
		Debug.Log (Time.timeSinceLevelLoad + " Host started.");
	}

	/// <summary>
	/// Raises the start client event.
	/// </summary>
	/// <param name="myClient">My client.</param>
	public override void OnStartClient(NetworkClient myClient)
	{
		Debug.Log (Time.timeSinceLevelLoad + " Client start requested.");
		InvokeRepeating ("PrintDots", 0f, 1f);
	}

	/// <summary>
	/// Raises the client connet event.
	/// </summary>
	/// <param name="conn">Conn.</param>
	public override void OnClientConnect(NetworkConnection conn)
	{
		Debug.Log (Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
		CancelInvoke();
	}

	void PrintDots()
	{
		Debug.Log (".");
	}
}
