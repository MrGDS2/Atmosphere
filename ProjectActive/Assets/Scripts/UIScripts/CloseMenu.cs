using UnityEngine;
using System.Collections;

public class CloseMenu : MonoBehaviour {

    public GameObject Menu;
	// Use this for initialization
	void Start () {

      Instantiate(Menu, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
