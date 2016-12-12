using UnityEngine;
using System.Collections;

public class ShowTextTimed : MonoBehaviour {

    /*
     * George Samuels II
     * 
     * 
     */

    private bool showText = false, someRandomCondition = true;
    private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 5.0f;
    public static ShowTextTimed instance;


   void Start()
    {
        instance = this;
    }
    void OnMouseDown()
    {
        executedTime = Time.time;
    }

  public void Text()
    {
        currentTime = Time.time;
        if (someRandomCondition)
            showText = true;
        else
            showText = false;

        if (executedTime != 0.0f)
        {
            if (currentTime - executedTime > timeToWait)
            {
                executedTime = 0.0f;
                someRandomCondition = false;
            }
        }
    }

    void OnGUI()
    {
        if (showText)
            GUI.Label(new Rect(0, 0, 100, 100), "Success!");
    }

    /*
    * 
    */
}
