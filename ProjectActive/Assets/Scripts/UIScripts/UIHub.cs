using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UIHub : MonoBehaviour {


  public  GameObject UICounter;
 //public GameObject Counter;
    public GameObject HeadVR;
    // public Text Count;
	// Use this for initialization
	void Start () {

  GameObject child= Instantiate(UICounter,UICounter.transform.position,UICounter.transform.rotation) as GameObject;

        child.transform.parent = HeadVR.transform; //sets UIhub as child of OVRheadMount 


        //GameObject childII = Instantiate(Counter, Counter.transform.position, Counter.transform.rotation) as GameObject;

       // childII.transform.parent = HeadVR.transform;
        //UI field

        //Count.text = GazeExplosion.instance.Counting().ToString();

        //  Count.transform.FindChild("AsteroidCounter");
    }
	
	// Update is called once per frame
	void Update () {
    
    }
}
