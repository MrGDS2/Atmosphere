using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//George samuels II
public class Timer : MonoBehaviour {
    public Text AtmosphereTimer;
    public Text AsteroidCounter;
    public GameObject LoadingImage;
    public ArrayList Scores;
    public AudioClip soundclip;


    // public GameObject Blackhole;
    private float startTime;
    private bool goal = false;
    private string sec;
    private string min;

    private AudioSource audio { get { return GetComponent<AudioSource>(); } }
    // Use this for initialization
    void Start () {
        startTime=Time.time;
        Scores = new ArrayList();//puts scores in an array?
        gameObject.AddComponent<AudioSource>();//initialize Audio Source / creates on an object on the object
    }
	
	// Update is called once per frame
	void Update () {

        if (goal)
             return;
            
        
        //stops timer when asteroid number reached

        float t = Time.time - startTime; //gets time in level

       min= ((int)t / 60).ToString();
       sec  = (t % 60).ToString("f2");//f2 turns float decimals to 2 decimals
        

        AtmosphereTimer.text = min + ":" + sec;
        //after 55sec timer stops TimeEnded(sec);

        GoalAcheived();


	}


    void TimeEnded(string time)
     {
        /**goals depending on level

            if (time.Equals("55") && Application.loadedLevel==1)
        {    goal = true;
             AtmosphereTimer.color = Color.red;
        }**/

        }
     void GoalAcheived()
    {
        /**goals depending on level**/
        Scene scene = SceneManager.GetActiveScene();


        if (GazeExplosion.instance.Counting() == 4 && scene.name.Equals("Tutorial"))
        {
            SuccessPing();
            
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
            SceneManager.LoadScene(0);//loads "Main"
          
        }
        if (GazeExplosion.instance.Counting()==10 &&  scene.name.Equals("AtmosphereEASY"))
        {   

             SuccessPing();    
            goal = true;//stop timer
            PlayerPrefs.SetString("player1Asteroids", AsteroidCounter.text);//saves player asteroids
            PlayerPrefs.SetString("player1", AtmosphereTimer.text);//saves player time
         //   Debug.Log("saved time" + "Timer=>LINE 64");
            Scores.Add(AtmosphereTimer.text);
            Debug.Log("New High score===>" + Scores.ToString());
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
          
            randomAsteroids.instance.stop = true;//stops random asteroids
            Debug.Log("Scene " + scene.name);
           SceneManager.LoadScene(4);//loads "EndGame"
            
         //   Debug.Break();
            Debug.Log("playerpref "  + PlayerPrefs.HasKey("player1"));

        }
        if (GazeExplosion.instance.Counting() == 15 && scene.name.Equals("EasyLvL2"))
        {

            SuccessPing(); //plays sound
            goal = true;//stop timer
                        //    PlayerPrefs.SetString("player1", AtmosphereTimer.text);//saves player time
                        //   Debug.Log("saved time" + "Timer=>LINE 64");
            Scores.Add(AtmosphereTimer.text);
            Debug.Log("New High score===>" + Scores.ToString());
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
          
            randomAsteroids.instance.stop = true;//stops random asteroids
            Debug.Log("Scene " + scene.name);
         //   SceneManager.LoadScene(6);//loads "EndGame"
                                      //   Debug.Break();
            Debug.Log("playerpref " + PlayerPrefs.HasKey("player1"));

       
        }
        else if (GazeExplosion.instance.Counting() == 20 && scene.name.Equals("AtmosphereModerate"))
        {
            SuccessPing(); //plays sound
            goal = true;//stop timer
            PlayerPrefs.SetString("player1Asteroids", AsteroidCounter.text);//saves player asteroids
            PlayerPrefs.SetString("player1", AtmosphereTimer.text);//saves player time
            AtmosphereTimer.color = Color.green;
         AsteroidCounter.color = Color.green;
           
            randomAsteroids.instance.stop = true;//stops random asteroids
            Debug.Log("Scene " + scene.name);                                    
            SceneManager.LoadScene(5);//loads "EndGame"                                  

            //     LoadScene(2);
            //  Instantiate(Blackhole, asteroid.transform.position, asteroid.transform.rotation);  black hole to next scene

        }
        else if (GazeExplosion.instance.Counting() == 25 && scene.name.Equals("ModerateLvL2"))
        {
            goal = true;//stop timer
         //   PlayerPrefs.SetString("player1Asteroids", AsteroidCounter.text);//saves player asteroids
          //  PlayerPrefs.SetString("player1", AtmosphereTimer.text);//saves player time
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
            SuccessPing(); //plays sound
            randomAsteroids.instance.stop = true;//stops random asteroids
            Debug.Log("Scene " + scene.name);
         //   SceneManager.LoadScene(5);//loads "EndGame"                                  

            //     LoadScene(2);
            //  Instantiate(Blackhole, asteroid.transform.position, asteroid.transform.rotation);  black hole to next scene

        }
        else  if (GazeExplosion.instance.Counting() == 30 && scene.name.Equals("AtmosphereInsane"))
        {
            SuccessPing(); //plays sound
            goal = true;//stop timer
            PlayerPrefs.SetString("player1Asteroids", AsteroidCounter.text);//saves player asteroids
            PlayerPrefs.SetString("player1", AtmosphereTimer.text);//saves player time
            AtmosphereTimer.color = Color.green;
          AsteroidCounter.color = Color.green;
         
            randomAsteroids.instance.stop = true;//stops random asteroids
             Debug.Log("Scene " + scene.name);
            SceneManager.LoadScene(6);//loads "EndGame"

        }

    }




void SuccessPing()
    {
       audio.clip = soundclip;
        audio.Play();
        
      
    }
}
