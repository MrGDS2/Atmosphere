using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//George samuels II
public class ReloadLevel : MonoBehaviour
{
  
 //   public Text ShowFinalAsteroids;
  //  public Text ShowFinalTime;
    public static ReloadLevel instance;

    // Use this for initialization
    void Start()
    {
        instance = this;

        GazeExplosion.Counter = 0;//reset counter to zero for each level
        SyncGazeExplosion.Counter = 0;//reset for Network
       
    }

    // Update is called once per frame
    void Update()
    {

        //  Debug.Log("Reset Count=>" + GazeExplosion.instance.Counting());
        //Network

      
    }

    

}