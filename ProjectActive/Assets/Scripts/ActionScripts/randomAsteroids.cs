using UnityEngine;
using System.Collections;
//Saima Khot
public class randomAsteroids : MonoBehaviour {

    public GameObject[] asteroids;
    public Vector3 spawnValues;
    public int startWait;
    public float spawnWait;
    public float spawnMaxWait;
    public float spawnMinWait;
    public bool stop;

    int randAsteroid;
	void Start ()
    {
        StartCoroutine(waitForNextAsteroid());
	}
	
	void Update ()
    {
        spawnWait = Random.Range(spawnMinWait, spawnMaxWait); //set to number of spawn MAx/min
	}

    IEnumerator waitForNextAsteroid()
    {
        yield return new WaitForSeconds(startWait); //wait for amount of time before loop

        while (!stop)
        {
            randAsteroid = Random.Range(0, 3);

            /**Spawn position**/
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(asteroids[randAsteroid], spawnPosition + transform.TransformPoint (0,0,0), gameObject.transform.rotation);//creates positons and spawns asteroids

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
