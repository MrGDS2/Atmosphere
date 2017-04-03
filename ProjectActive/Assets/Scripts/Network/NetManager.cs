using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NetManager : MonoBehaviour
{


    public Text Player;
    public Text Player2;
    private int Count;

  //  private static int Count;
    //  private Color Connected = ColorUtility.TryParseHtmlString("A7F4BAFF",)
    private const string VERSION = "1.0";
    // Use this for initialization
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(VERSION);//reads data and throw to server
        var temp = PhotonVoiceNetwork.Client;//sets up client for chating
                                             //  randomAsteroids.instance.stop = true;//stops asteroids


    }

    // Update is called once per frame
    void Update()
    {
        OnFullroom();//updates room size
        OnDisconnect();//updates room size disconnect
      

    }

    public virtual void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 2}, null);");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { MaxPlayers = 2 }, null);

        //3.5.17  changed to 2 player room
    }

    // the following methods are implemented to give you some context. re-implement them as needed.

    public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }

    public void OnJoinedRoom()
    {
       
        Debug.Log("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
           if (Count==0)//saying player one has joined
       Player.color = Color.green;

        
 

    


      
     

        Debug.Log("OnJoinedRoom()" + " Players:" + PhotonNetwork.countOfPlayers);


    }
    
    void OnFullroom()
    {
        if (PhotonNetwork.room.playerCount == 2)
        {
            //when player 2 joins room
            Count++;//count goes up and if player 1 leaves we will be notified
            //Player 2 lights up green indicating connection
            Player2.color = Color.green;
            Timeout.instance.players = true;
            randomAsteroids.instance.stop = false;//starts asteroids
                                                  // PhotonNetwork.Instantiate(p2Avatar.name, p2Avatar.transform.position, p2Avatar.transform.rotation, 0);
     //     p2Avatar.GetComponent<MeshRenderer>().enabled = true;
            //Player 2 UI count spawn
          
        }
        else Timeout.instance.players = false;//stops time

    }
    void OnDisconnect()
    {
        
        
           // randomAsteroids.instance.stop = true;//stops asteroids
        

       
        if (PhotonNetwork.room.playerCount < 2 &&
            PhotonNetwork.isNonMasterClientInRoom)     //player 2 DC'D =>disconnected
        {
            Debug.Log( "player2 dcd:" + PhotonNetwork.isNonMasterClientInRoom.ToString());
            Player2.color = Color.red;
        }                                                                       /** checks to see if player 1 has DC'd => disconnected**/
        if (PhotonNetwork.room.playerCount < 2 && 
            !PhotonNetwork.isNonMasterClientInRoom
            && Count!=0)
        {      
             Player.color = Color.red;
            Debug.Log(" Players:" + PhotonNetwork.room.playerCount);
           // Timeout.instance.players = false;//stops clock
            Debug.Log("player2 dcd: now " + PhotonNetwork.isNonMasterClientInRoom.ToString());
        }



    }

    /**
    public void OnPhotonPlayerConnected(PhotonPlayer player)
{
    Debug.Log("Player Connected " + player.name);
}

public void OnPhotonPlayerDisconnected(PhotonPlayer player)
    {
        Debug.Log("Player Disconnected " + player.name);
    }
 **/
}
