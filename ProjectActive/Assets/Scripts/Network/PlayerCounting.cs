using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounting: Photon.MonoBehaviour {

    // Use this for initialization
    public Text CountingAsteroidText, CountingAsteroidText2;
   private string player1score, player2score;
    public static PlayerCounting instance;
    private PhotonView view;
   // public int number;
	void Start () {
        //   CountingAsteroidText = GameObject.Find("Playercount").GetComponentInChildren<Text>();
        view = new PhotonView();
        instance = this;
    }

// Update is called once per frame
void Update () {

      


        if (photonView.isMine)
        {
            CountingAsteroidText.color = Color.green;
            CountingAsteroidText.text = SyncGazeExplosion.instance.Counting().ToString();
            CountingAsteroidText2.color = Color.yellow;
    

        }
       
    

    


	}







    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {

       
        Debug.Log("OnPhotonSerializeView()");
        if (stream.isWriting == true)
        {  //sends information to player 2 
           // We own this player: send the others our data
            stream.SendNext(CountingAsteroidText.text);
         


        }
        else  //issue
        {

            // Network player, receive data
            //player 2 receives the information
            CountingAsteroidText.text = (string)stream.ReceiveNext();
          

        }



    }

 




      
    //4.2.17
}





