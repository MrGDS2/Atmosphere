using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Text AtmosphereTimer;
    public Text AsteroidCounter;
    public GameObject LoadingImage;
    public GameObject FinishMenu;
   // public GameObject Blackhole;
    private float startTime;
    private bool goal = false;
  
	// Use this for initialization
	void Start () {
        startTime=Time.time;
       
	}
	
	// Update is called once per frame
	void Update () {

        if (goal)
            return;
        //stops timer when asteroid number reached

        float t = Time.time - startTime; //gets time in level

        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");//f2 turns float decimals to 2 decimals
        

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
        if (AsteroidCounter.text.Equals("5") &&  scene.name.Equals("AtmosphereEASY"))
        {   goal = true;//stop timer
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
            randomAsteroids.instance.stop = true;//stops random asteroids
            Debug.Log("Scene " + scene.name);

        }
   else if (AsteroidCounter.text.Equals("1") && scene.name.Equals("AtmosphereModerate"))
        {
            goal = true;//stop timer
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
            randomAsteroids.instance.stop = true;//stops random asteroids
            Debug.Log("Scene " + scene.name);                                     //menu pop up
                                                 // Application.Quit();

            //     LoadScene(2);
            //  Instantiate(Blackhole, asteroid.transform.position, asteroid.transform.rotation);  black hole to next scene

        }
        if (AsteroidCounter.text.Equals("2") && scene.name.Equals("AtmosphereInsane"))
        {
            goal = true;//stop timer
            AtmosphereTimer.color = Color.green;
            AsteroidCounter.color = Color.green;
            randomAsteroids.instance.stop = true;//stops random asteroids
                                                 //menu pop up
            Debug.Log("Scene " + scene.name);

        }

    }




void LoadScene(int level)
    {

        LoadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
}
