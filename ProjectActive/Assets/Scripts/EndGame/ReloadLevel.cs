using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//George samuels II
public class ReloadLevel : MonoBehaviour
{
    //FIXME resetKeys doesn't really work * 12/11/16

    public Text ShowFinalAsteroids;
    public Text ShowFinalTime;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowFinalAsteroids.text = "Asteroids Destroid:\n" + PlayerPrefs.GetString("player1Asteroids");

        ShowFinalTime.text = "Time:\n" +PlayerPrefs.GetString("player1");
    }

    public void resetKeys()
    {
        /** Deletes Player numbers with each restart or progression**/
        PlayerPrefs.DeleteAll();


      /**  PlayerPrefs.DeleteKey("player1");
        PlayerPrefs.DeleteKey("player1Asteroids"); **/
    }

}