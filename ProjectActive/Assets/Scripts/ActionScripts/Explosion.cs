using UnityEngine;
using System.Collections;

public class Explosion: MonoBehaviour {

	public GameObject explosionPrefab;
    public GameObject asteroid;

   
    public void BOOM()
    {
        
       Destroy (asteroid,2f);//waits two sec and destroys
        
   /***Next is the Explosion   **/
var exp = GetComponent<ParticleSystem> ();
		exp.Play ();

		RaycastHit hit;

		if (Physics.Raycast (new Ray (Camera.main.transform.position, Camera.main.transform.forward), out hit)) 
		{
			Instantiate (explosionPrefab, hit.point, Quaternion.identity);
		}
	

    }

   
}
	