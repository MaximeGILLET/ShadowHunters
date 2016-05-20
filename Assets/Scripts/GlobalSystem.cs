using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GlobalSystem : NetworkBehaviour {

    public string MyUsername;
	public Character CurrentPlayer;
	// Use this for initialization
	NetworkClient myClient;

    public class MyMsgType
    {
        public static short Chat = MsgType.Highest + 1;
    };

    public class ChatMessage : MessageBase
    {
        public string username;
        public string message;
    }

    public void SendChatMessage(string message)
    {
        ChatMessage msg = new ChatMessage();
        msg.username = MyUsername;
        msg.message = message;

        NetworkServer.SendToAll(MyMsgType.Chat, msg);
    }

    public void OnConnected(NetworkMessage netMsg) {
		Debug.Log("Connected to server");
	}

	public void OnDisconnected(NetworkMessage netMsg) {
		Debug.Log("Disconnected from server");
	}

	public void OnError(NetworkMessage netMsg) {
		Debug.Log("Error connecting with code " + netMsg.reader.ReadString());
	}


	public void Start() {
		myClient =new NetworkClient();
	
	
		myClient.RegisterHandler(MsgType.Connect,OnConnected);
		myClient.RegisterHandler(MsgType.Disconnect, OnDisconnected);
		myClient.RegisterHandler(MsgType.Error, OnError);

		myClient.Connect("127.0.0.1", 8888);

        SendChatMessage("coucou");

    }
	
	// Update is called once per frame
	void Update () {
	

      
		// Character distribution


		// Game routine 


		// Game Ending (resolve winners)
	}

	private void ResolveVisionCards(){

		// Resolve effects of vision cards if any.
	}

	private void PickLocation(){
	
		// Pick random location.

		// Move current player token to location.
	}

	private void ApplyLocationEffect(){

		// Apply effects (Draw cards, deal damage, steal equipement ...).
	}

	private void AttackPhase(){

		// Chose a valid player to attack.

		// Resolve Damages.

	}
}
