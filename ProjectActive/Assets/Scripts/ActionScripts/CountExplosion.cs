using UnityEngine;
using System.Collections;
using UnityEngine.UI;


/// <summary>
/// George samuels II 
/// 
/// 
/// FIx ME:11/22/2016
/// </summary>



public class CountExplosion: MonoBehaviour {

	public GameObject explosionPrefab;
    public GameObject asteroid;
    public double lookingTime=1;
    public Text CountAsteroids;
  //  public AudioClip soundclip;
    public AudioSource Bang;
   private int TotalAsteroids;

    
  /**Initialize BAng **/ 
   void Awake()
    {
      
 Bang = GetComponent<AudioSource>();
      TotalAsteroids = 0;
      

    }

  void BOOM()
    {
  UpdateAsteroidCount();
       
        RaycastHit hit;
        if (Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.forward), out hit)) //adjust the raycast  FIXME:11/22/16
        {
            lookingTime--;
            
           Debug.Log("You have destroy start # " + TotalAsteroids);
        print("GAZE TIME ==>" + lookingTime);
            
            if (lookingTime <= 0)
            {


          /***Explosion  after gaze time of x number of secs **/
                Bang.Play(); //Bang sound effect won't work?
                Instantiate(explosionPrefab, asteroid.transform.position, asteroid.transform.rotation);
               Destroy(asteroid);
                Debug.Log(asteroid.name + "===> has been Blown up" +  "Asteroids: " + TotalAsteroids);
            AddCount(TotalAsteroids);


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
        lookingTime = 1;

    }

    void Counter()
    {
        //??
       
       
     
      
        
    }

     void AddCount(int blownupAsteroid)
    {
       TotalAsteroids+= blownupAsteroid;
       Debug.Log("AddCOunt ==>" + TotalAsteroids);
        UpdateAsteroidCount();
        if (TotalAsteroids == 5)
        {
            //end lvl
            CountAsteroids.color = Color.green;
            Debug.Log("Got Five asteroids ==>" + TotalAsteroids);
            //   gameObject.SendMessage("GoalAcheived"); //returns goal to stop timer
        }
    }

    void UpdateAsteroidCount()
    {
 print("You have destroyed end # " + TotalAsteroids);
        CountAsteroids.text = TotalAsteroids.ToString();  //out puts to user 
        Debug.Log("UpdateAsteroidCount==>" + TotalAsteroids);
    }

    /**
    void LoadScene(int level)
    {

        LoadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
    **/
       /** foreach(GameObject item in BlownUp)
        {

             BlownUp = new ArrayList();  Counter();

        }
   **/


}
	