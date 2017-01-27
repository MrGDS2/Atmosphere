using UnityEngine;
using System.Collections;

public class Incoming : MonoBehaviour {
    public GameObject Alertmenu;
    public AudioClip alert;
    private int timeup;
    private AudioSource audio { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        gameObject.AddComponent<AudioSource>();//adds audio component 

    }



	void Awake() {
        Instantiate(Alertmenu, Alertmenu.transform.position, Alertmenu.transform.rotation);
        playAlert();//plays alert

    
    }
	
	// Update is called once per frame
	void Update () {

        timeup++;
        Debug.Log("timeup" + timeup);
        if (timeup == 2)
            Destroy(Alertmenu);
	}


    void playAlert()
    {
        audio.clip = alert;
        audio.Play();
    }
}
