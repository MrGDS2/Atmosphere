using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/***
 * Master Counter Checks both users scores
 * 
 * 
 * ***/

public class PlayerCounting : Photon.MonoBehaviour
{

    // Use this for initialization
    public Text CountingAsteroidText, CountingAsteroidText2;
    private string player1score, player2score;
    public static PlayerCounting instance;
    private PhotonView view;
    // public int number;
    void Start()
    {
        //   CountingAsteroidText = GameObject.Find("Playercount").GetComponentInChildren<Text>();
        view = new PhotonView();
        instance = this;
        Scene scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {




        if (photonView.isMine)
        {
            CountingAsteroidText.color = Color.white;
            CountingAsteroidText.text = SyncGazeExplosion.instance.Counting().ToString();
            CountingAsteroidText2.color = Color.yellow;
         //   PlayerPrefs.SetString("player1Score", CountingAsteroidText.text);

        }


        CheckWinner(CountingAsteroidText.text, Player2Count.instance.CountingAsteroidText2.text);



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

    void CheckWinner(string p1 ,string p2)
    {
        //results to change scene
      
      if(p1.Equals("10")|| p2.Equals("10"))
        {
            //swtich scene
            PhotonNetwork.LoadLevel(9);

        }


    }







    //4.2.17
}





