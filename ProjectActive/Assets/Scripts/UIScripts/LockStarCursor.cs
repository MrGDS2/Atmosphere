using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockStarCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LockCursor();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void LockCursor()
    {
#if !UNITY_ANDROID || UNITY_EDITOR
        // Lock the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Debug.Log("Lock cursor");
#endif
    }


}
