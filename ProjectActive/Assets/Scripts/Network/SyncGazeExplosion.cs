using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncGazeExplosion : Photon.MonoBehaviour {

    public GameObject explosionPrefab;
    public GameObject asteroid;
    public double lookingTime = 0.5;
    //   public Text AsteroidCounter;
    public static int Counter = 0;
    public static SyncGazeExplosion instance;
    public AudioClip[] AsteroidSounds;

    private AudioSource audio { get { return GetComponent<AudioSource>(); } }

    /**Initialize BAng **/
    void Start()
    {
        instance = this;

        /**sound for asteroids explosion**/
        gameObject.AddComponent<AudioSource>();//initialize Audio Source / creates on an object

      //  PhotonNetwork.Instantiate(UIhub.name, UIhub.transform.position, UIhub.transform.rotation, 0);


    }




    void Update()
    {
    }


   
    public void BOOM()
    {
        

        RaycastHit hit;

        if (Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.rotation * Vector3.forward), out hit, 500.0f)) //adjust the raycast  FIXME:11/22/16
        {
            /**time of gaze**/
            lookingTime--;
            print("GAZE TIME ==>" + lookingTime);


            asteroid.GetComponent<MeshRenderer>().enabled = false;
            PlayClip();
            
           // PhotonNetwork.Instantiate(explosionPrefab.name, asteroid.transform.position, asteroid.transform.rotation,0);
           PhotonNetwork.Destroy(asteroid);
            // Destroy(asteroid,1f);
         Instantiate(explosionPrefab, asteroid.transform.position, asteroid.transform.rotation);
          //destroys over network
             // 


            //hides mess to play sound longer

            // 1/ 14/17
            Debug.Log(asteroid.name + "===> has been Blown up" + "Asteroids: " + Counter++);
            //  Debug.Break();
            Counting();


        }




    }

    void PlayClip()
    {

        /**Plays Random sound on explosion**/
        int clip;

        clip = Random.Range(0, 10);
        audio.clip = AsteroidSounds[clip];
        audio.Play();
        Debug.Log(clip + "sound");
        //   Debug.Break();

    }

    public int Counting()
    {
        //temp to fix counting issue 12/11/16
        //TODO:FIXME
        Debug.Log("Counting LINE 95" + "===> " + Counter);

        //resets asteroid counter 
        //to zero for new levels after playerpref deleted.



        return Counter;
    }

    /***Counts only on Gaze **/
    public void GazeOn()
    {
        InvokeRepeating("BOOM", 1, 1);


    }


    /***Resets off Gaze **/
    public void Gazeoff()
    {
        CancelInvoke();
        //  lookingTime =0.5;

    }

}
