using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : Photon.MonoBehaviour
{
    public GameObject mic,asteroid,explosionPrefab;
    private static System.EventArgs e;
   OVRTouchpad.TouchArgs touchArgs = (OVRTouchpad.TouchArgs)e;
    // Update is called once per frame
    PhotonVoiceRecorder talk = new PhotonVoiceRecorder();
    void Update()
    {

     //   talk.Transmit = true;

        if (photonView.isMine) {

            //enables voice chat
            GetComponent<PhotonVoiceRecorder>().enabled = true;
          //gives time for destroying object   Destroy(asteroid, 1f);
           // "back" button of phone equals "Escape". quit app if that's pressed     Instantiate(explosionPrefab, asteroid.transform.position, asteroid.transform.rotation);
        
            //    Debug.LogWarning("Mic is on");
            /**   if (Input.GetKeyDown(KeyCode.Escape))
               {        //disables voice chat
                   GetComponent<PhotonVoiceRecorder>().enabled = false;
                   talk.Transmit = false;
                   //&& PhotonNetwork.room.playerCount==2
                   Destroy(mic);
                   Debug.LogWarning("Mic is muted");
           } */


        }
    }

  
        
    }
  



