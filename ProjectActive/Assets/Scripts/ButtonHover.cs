using UnityEngine;
using System.Collections;

public class ButtonHover : MonoBehaviour {
    public int timeRemaining = 5;
    public GameObject Object;
	

   void Counter()
    {
        //counts down time remaining for action
        timeRemaining--;
        print(timeRemaining);
        if(timeRemaining<=0)
        {
            Action();
            //explostion of asteroids



            //cancel n
            CancelInvoke("Counter");
            timeRemaining = 5;
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
        timeRemaining = 5;
    }
}
