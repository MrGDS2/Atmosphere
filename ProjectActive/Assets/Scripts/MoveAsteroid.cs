using UnityEngine;
using System.Collections;
/**
 * George Samuels II 
 * 
 *      **/
public class MoveAsteroid : MonoBehaviour {
	public float speed=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, speed*Time.deltaTime,0); //moves object towards user
	
	}
}
