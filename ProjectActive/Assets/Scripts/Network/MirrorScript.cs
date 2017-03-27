using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : Photon.MonoBehaviour
{
    //public GameObject UIhub;
    private static System.EventArgs e;
   OVRTouchpad.TouchArgs touchArgs = (OVRTouchpad.TouchArgs)e;
    // Update is called once per frame
    PhotonVoiceRecorder talk = new PhotonVoiceRecorder();


    void Start()
    {
       // PhotonNetwork.Instantiate(UIhub.name, UIhub.transform.position, UIhub.transform.rotation, 0);

    }
    void Update()
    {  
     //   talk.Transmit = true;

      //  if (photonView.isMine) {

            //enables voice chat
            GetComponent<PhotonVoiceRecorder>().enabled = true;

          

      //  }
    }

  
        
    }
  



