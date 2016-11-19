using UnityEngine;
using System.Collections;

public class Clonerock : MonoBehaviour {
    public GameObject prefab;
	// Use this for initialization
	void Start () {
        float x;
        float y;
        float z;
        Vector3 pos;
       x = Random.Range(-25, 26);
        y = 5;
        z = Random.Range(-25, 26);
        pos = new Vector3(x, y, z);
     
   transform.position = pos;
        for (int i=0;i<10;i++)
        {
            Instantiate(prefab,transform.position, Quaternion.identity);
            
         //    new Vector3(i * 2.0f, 0, 0)

        }


 

    }
	
	// Update is called once per frame
	void Update () {


	
	}
}
