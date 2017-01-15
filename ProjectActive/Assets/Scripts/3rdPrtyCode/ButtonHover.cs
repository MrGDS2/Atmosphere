using UnityEngine;
using System.Collections;

public class B: MonoBehaviour {
    public int timeRemaining=3;
   // public GameObject Object;
	   public GameObject LoadingImage;
      public int lvl;
    //string displayTime;

void Counter()
    {
        //counts down time remaining for action
        timeRemaining--;
        print(timeRemaining);
      //  displayTime =timeRemaining.ToString();
    
        if (timeRemaining<=0)
        {
            //Action();
            //explostion of asteroids
         LoadScene(lvl);

            //cancel n
            CancelInvoke("Counter");
            timeRemaining =3;
            print("reset counter");
        }

    }


    void Action()
    {
        print("Action fired"); //debug
     //   Object.transform.Rotate = newRotate;
    }


    public void MouseOver()
    {
        InvokeRepeating("Counter", 1, 1);

    }

    public void MouseOut()
    {
        CancelInvoke("Counter");
        timeRemaining=2;
    }

 

    void LoadScene(int level)
    {

        LoadingImage.SetActive(true);
        Application.LoadLevel(level);
    }

}
