using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildScreenTutorial : MonoBehaviour {

    public GameObject tutorialScreen;
	// Use this for initialization
	void Start () {
		Instantiate(tutorialScreen, tutorialScreen.transform.position, tutorialScreen.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    
    public void kill()
    {
        Destroy(tutorialScreen);
    }
    
    
    
}
