using UnityEngine;
using System.Collections;
using UnityEngine.UI;


/// <summary>
/// George samuels II 
/// 
/// 
/// FIx ME:11/22/2016
/// </summary>



public class GazeExplosion : MonoBehaviour
{

    public GameObject explosionPrefab;
    public GameObject asteroid;
    public double lookingTime =0.5;
    public AudioClip soundclip;
    public Text AsteroidCounter;
    public static int Counter = 0;
    private AudioSource Bang;
    /**Initialize BAng **/
    void Awake()
    {


    }

    void BOOM()
    {
        // UpdateAsteroidCount();

        RaycastHit hit;
        if (Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.forward), out hit)) //adjust the raycast  FIXME:11/22/16
        {
            lookingTime--;

            print("GAZE TIME ==>" + lookingTime);

            if (lookingTime <= 0)
            {
                /***Explosion  after gaze time of x number of secs **/
                //Bang sound effect won't work?
                Bang = GetComponent<AudioSource>();
                Bang.clip = soundclip;
                Bang.Play();
               
                Instantiate(explosionPrefab, asteroid.transform.position, asteroid.transform.rotation);
               
                Debug.Log(asteroid.name + "===> has been Blown up" + "Asteroids: " + Counter++);
                AsteroidCounter.text = Counter.ToString();//problem?
                Destroy(asteroid);
            }

        }




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
        lookingTime =0.5;

    }







}
