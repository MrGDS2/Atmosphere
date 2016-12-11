using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// George samuels II 
/// 
/// 
/// FIx ME:11/22/2016  * FIXED
/// 
/// 
/// 
/// 
/// 
/// 
/// FIXME: 12/11/16 Counter to text is broken =>prefab?
/// </summary>



public class GazeExplosion : MonoBehaviour
{

    public GameObject explosionPrefab;
    public GameObject asteroid;
    public double lookingTime =0.5;
    public AudioClip soundclip;
    public Text AsteroidCounter;
    public static int Counter = 0;
    public static GazeExplosion instance;
    private AudioSource Bang;

    /**Initialize BAng **/
    void Start()
    {
        instance = this;
    }
    void Update()
    {  }


    /**Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
         if (Physics.Raycast(ray, out hit, 2))
             Debug.DrawLine(ray.origin, hit.point);**/
    void BOOM()
    {
        // UpdateAsteroidCount();

        RaycastHit hit;

        if (Physics.Raycast(new Ray(Camera.main.transform.position,Camera.main.transform.rotation* Vector3.forward), out hit,500.0f)) //adjust the raycast  FIXME:11/22/16
        {
            lookingTime--;
            print("GAZE TIME ==>" + lookingTime);
          
             // if (lookingTime == 0)
               // {
                    //Explosion  after gaze time of x number of secs
                    //Bang sound effect won't work?
                    Bang = GetComponent<AudioSource>();
                    Bang.clip = soundclip;
                    Bang.Play(); 

                    Instantiate(explosionPrefab, asteroid.transform.position, asteroid.transform.rotation);
                    Destroy(asteroid);
                    Debug.Log(asteroid.name + "===> has been Blown up" + "Asteroids: " + Counter++);
                     Counting();


            /**goals depending on level**/
            Scene scene = SceneManager.GetActiveScene();
          switch(scene.name)
            {
                case "AtmosphereEASY":
                 AsteroidCounter.text = Counter.ToString()+"/5";
                   PlayerPrefs.SetString("player1Asteroids", AsteroidCounter.text);//saves player asteroids

                    break;
                case "AtmosphereModerate":
                    AsteroidCounter.text = Counter.ToString() + "/10";
                    break;
                case "AtmosphereInsane":
                    AsteroidCounter.text = Counter.ToString() + "/15";
                    break;
              
            }




        }
       

        }




 
    public int Counting()
    {
        //temp to fix counting issue 12/11/16
        //TODO:FIXME
        Debug.Log("Counting LINE 95" + "===> " + Counter);
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

    


   /** void UpdateAsteroidTracker(string update)
    {
        AsteroidCounter.text =update;
    }**/
   }







