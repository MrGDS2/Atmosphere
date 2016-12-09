using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonHover : MonoBehaviour {
    public int timeRemaining=2;
   // public GameObject Object;
	   public GameObject LoadingImage;
      public int lvl;

void Counter()
    {
        //counts down time remaining for action
        timeRemaining--;

        Debug.Log("TimeRemaining "
   + timeRemaining);

      //  OnGUI();
     
        if (timeRemaining<=0)
        {
        
            //change to next scene
         LoadScene(lvl);

            //cancel n
            CancelInvoke("Counter");
            timeRemaining =2;
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


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), timeRemaining.ToString());//displays time to screen
    }
  public void LoadScene(int level)
    {

        LoadingImage.SetActive(true);
        SceneManager.LoadScene(level);
    }

}
