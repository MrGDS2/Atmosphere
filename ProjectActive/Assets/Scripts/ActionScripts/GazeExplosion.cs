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
   public Camera MainCamera;
    /**Initialize BAng **/
    void Awake()
    {


    }
    void Update()
    { }


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
          
                if (lookingTime <= 0)
                {
                    //Explosion  after gaze time of x number of secs
                    //Bang sound effect won't work?
                    Bang = GetComponent<AudioSource>();
                    Bang.clip = soundclip;
                    Bang.Play(); 

                    Instantiate(explosionPrefab, asteroid.transform.position, asteroid.transform.rotation);
                    Destroy(asteroid);
                    Debug.Log(asteroid.name + "===> has been Blown up" + "Asteroids: " + Counter++);
                AsteroidCounter.text = Counter.ToString();  //problem?
               /** if (asteroid.tag.Equals("SpecialAsteroid"))
                {
                    Destroy(asteroid);
                    Counter =  Counter += 2;
                    Debug.Log(asteroid.name + "GoldenNugget" + Counter);
                    UpdateAsteroidTracker(Counter.ToString());
                } **/
               
                


                     
              
                }
            
           
            }
           else
        {
            //distance = Camera.main.farClipPlane * 0.95f;//check this 
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


   /** void UpdateAsteroidTracker(string update)
    {
        AsteroidCounter.text =update;
    }**/
   }







