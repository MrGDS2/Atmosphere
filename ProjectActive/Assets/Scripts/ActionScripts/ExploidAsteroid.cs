using UnityEngine;
using System.Collections;

public class ExploidAsteroid : MonoBehaviour {

	public GameObject explosionPrefab;
    private ParticleSystem explos;
    public GameObject asteroid;
    // On the explosion object.

    void Awake()
    {
        explos = GetComponent<ParticleSystem>();
    }




    void update()
    {

        RaycastHit hit;
if (Physics.Raycast (new Ray (Camera.main.transform.position, Camera.main.transform.forward), out hit)) 
		{
            //Instantiate (explosionPrefab, hit.point, Quaternion.identity);
            Destroy(asteroid, 2f);//waits two sec and destroys
            Boom();
            Debug.Log("Boom");
		}
	

    }




	void Boom() 
	{
	
		explos.Play ();

		

		
		Destroy (gameObject);
	}

	//buttonhover
	//if buttonhover over asteroid then explode
}
	