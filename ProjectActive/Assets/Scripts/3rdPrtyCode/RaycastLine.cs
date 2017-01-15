using UnityEngine;
using System.Collections;

public class RaycastLine : MonoBehaviour {
    private float Thickness = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 origin = transform.position + new Vector3(0, 0.6f, -1.6f);
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 250;// distance forward
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 500.0f);
     //   Physics.SphereCast(origin, 10f, forward, out hit, 10);

            Debug.DrawRay(transform.position, forward, Color.green);
    }
}
