using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GoldenNugDestroyed : MonoBehaviour {


    public GameObject explosionPrefab;
    public GameObject Specialasteroid;
    public double lookingTime = 0.5;
    public AudioClip soundclip;
    public Text AsteroidCounter;
    public static int Counter = 0;
    private AudioSource Bang;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


  public void SpecialBoom()
    {
        RaycastHit hit;
        if (Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.rotation * Vector3.forward), out hit, 500.0f)) //adjust the raycast  FIXME:11/22/16
        {
            lookingTime--;
            print(" Golden Nugget GAZE TIME==>" + lookingTime);

            if (lookingTime == 0)
            {
                //Explosion  after gaze time of x number of secs
                //Bang sound effect won't work?
                Bang = GetComponent<AudioSource>();
                Bang.clip = soundclip;
                Bang.Play();

                Instantiate(explosionPrefab, Specialasteroid.transform.position, Specialasteroid.transform.rotation);
                Destroy(Specialasteroid);
                Debug.Log(Specialasteroid.name + "===> has been Blown up" + "Slowing Asteroids");
                GoldPowerUp();
                //cahnges the speed of all asteroids from 80 to 30
                Debug.Log("Current Asteroid Speed==>" +MoveAsteroid.instance.speed.ToString());
                //   AsteroidCounter.text = Counter.ToString();  





            }

        }

    }


    void GoldPowerUp()
    {

        /***
         * Gold asteroid will SLOW Down the asteroids when user hits this asteroid***/
        MoveAsteroid.instance.speed = 10f;

    }
}
