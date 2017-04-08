using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*****
   * 
   * 
   * Updated to reload Network level 4.7.17
   * 
   * 
   * 
   * **/

public class reloadNetwork : MonoBehaviour {
    public int level;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void load()
    {
        PhotonNetwork.LoadLevel(level);

        
    }
}
