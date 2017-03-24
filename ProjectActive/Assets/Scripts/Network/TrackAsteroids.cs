using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackAsteroids : Photon.MonoBehaviour {

    public static TrackAsteroids instance;
    public GameObject[] asteroids;
    public Vector3 spawnValues;
    public int startWait;
    public float spawnWait;
    public float spawnMaxWait;
    public float spawnMinWait;
    public bool stop;

    int randAsteroid;
    void Start()
    {
        instance = this;
        StartCoroutine(waitForNextAsteroid());
    }

    void Update()
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
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));
            PhotonNetwork.Instantiate(asteroids[randAsteroid].name, spawnPosition, Quaternion.identity,0);//creates positons and spawns asteroids

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
