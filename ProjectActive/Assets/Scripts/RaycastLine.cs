using UnityEngine;
using System.Collections;

public class RaycastLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 150;// distance forward
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 500.0f);

            Debug.DrawRay(transform.position, forward, Color.green);
    }
}
