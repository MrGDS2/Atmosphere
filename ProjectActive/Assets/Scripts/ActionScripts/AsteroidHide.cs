using UnityEngine;
using System.Collections;

public class AsteroidHide : MonoBehaviour {

    public int timeRemaining = 5;
    // public GameObject Object;
    public GameObject Asteroid;


    public void Counter()
    {
        //counts down time remaining for action
        timeRemaining--;
        print("timeRemaining" + timeRemaining);
        if (timeRemaining <= 0)
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
        /**Put asteroids in an array when hit
        foreach (GameObject go in Asteroid)
        {
            bool showing = GUILayout.Toggle(go.activeSelf, go.name);
            if (showing != go.activeSelf)
                go.SetActive(showing);

        }**/
        /**Put asteroids in an array when hit**/
        Asteroid.SetActive(false); //hide
    }
    void GUI()
    {
        
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
