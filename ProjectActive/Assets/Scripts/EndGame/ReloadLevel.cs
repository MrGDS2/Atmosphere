using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//George samuels II
public class ReloadLevel : MonoBehaviour
{
    //FIXME resetKeys doesn't really work * 12/11/16

 //   public Text ShowFinalAsteroids;
  //  public Text ShowFinalTime;
    public static ReloadLevel instance;
    // Use this for initialization
    void Start()
    {
        instance = this;

        GazeExplosion.Counter = 0;//reset counter to zero for each level
       
    }

    // Update is called once per frame
    void Update()
    {

      //  Debug.Log("Reset Count=>" + GazeExplosion.instance.Counting());

    }

    

}