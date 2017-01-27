using UnityEngine;
using System.Collections;
/**
 * George Samuels II 
 * 
 *      **/
public class MoveAsteroid : MonoBehaviour {
    public static MoveAsteroid instance;
	public float speed=5f;
    // Use this for initialization
    void Start()
    {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime); //moves object towards user
	
	}

    
}
