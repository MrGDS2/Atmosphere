using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounting: Photon.MonoBehaviour {

    // Use this for initialization
    public Text CountingAsteroidText, CountingAsteroidText2;
    private int networkcount;
   int i;
   // public int number;
	void Start () {
     //   CountingAsteroidText = GameObject.Find("Playercount").GetComponentInChildren<Text>();
       
    }

// Update is called once per frame
void Update () {
        if (photonView.isMine)
        {
            CountingAsteroidText.color = Color.green;
            CountingAsteroidText.text = SyncGazeExplosion.instance.Counting().ToString();
        }

       if(!photonView.isMine)
        {
            CountingAsteroidText2.color = Color.red;
            CountingAsteroidText2.text = SyncGazeExplosion.Counter.ToString();
        }




	}

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        Debug.Log("OnPhotonSerializeView()");
        if (stream.isWriting == true)
        {
            stream.SendNext(CountingAsteroidText.text);

        }
        else  //issue
        {

          CountingAsteroidText2.text= (string) stream.ReceiveNext();
        }

        // ...
    }



}
