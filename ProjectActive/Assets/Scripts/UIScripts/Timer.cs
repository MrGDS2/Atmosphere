using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text AtmosphereTimer;
    public GameObject LoadingImage;
    private float startTime;
    
    private bool goal = false;
    private int numbergoal;
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
        string sec = (t % 60).ToString("f2");//f2 turns float decimals to 2


        AtmosphereTimer.text = min + ":" + sec;

    //    if (min.Equals("1"))
      //      LoadScene(3);
	}


    public void GoalAcheived()
    {
        if (numbergoal == 1) {  goal = true;  AtmosphereTimer.color = Color.green;}
      
       

    }


    void LoadScene(int level)
    {

        LoadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
}
