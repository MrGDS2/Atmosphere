using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Count : Photon.MonoBehaviour
{

    // Use this for initialization
    public Text CountingAsteroidText, CountingAsteroidText2;
    private PhotonView view;
    public static Player2Count instance;
    void Start()
    {
     
        view = new PhotonView();
         instance=this;
    }

    // Update is called once per frame
    void Update()
    {




        if (!photonView.isMine)
        {
            CountingAsteroidText2.color = Color.green;
            CountingAsteroidText2.text = SyncGazeExplosion.instance.Counting().ToString();
            //   CountingAsteroidText.color = Color.yellow;
      
        
           
                photonView.RPC("ToMaster", PhotonTargets.MasterClient, CountingAsteroidText2.text);
            //RPC to master to show updated text

        }
       





    }

    [PunRPC]
    void ToMaster(string i)
    {
        PlayerCounting.instance.CountingAsteroidText2.text= i;
    }





   



    }







    // 4.2.17






