using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Timeout : MonoBehaviour
{
    public Text timer;
    public static Timeout instance;
    public bool players;
    float minutes = 5;
    float seconds = 0;
    float miliseconds = 0;
  

    void Start()
    {

      instance=this; //now i can call to timeout to start time when 2 players have joined
    }


    void Update()
    {

      if (players){
           
            if (miliseconds <= 0){
                if (seconds <= 0)
                {
                    minutes--;
                    seconds = 59;
                }
                else if (seconds >= 0){
                    seconds--;
                }

                miliseconds = 100;
            }
      
        miliseconds -= Time.deltaTime * 100;

        //Debug.Log(string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds));
        timer.text = string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds);
        if (timer.text.Equals("0:0:0")){
            SceneManager.LoadScene(0);//load results
        }
        }
    }
}
