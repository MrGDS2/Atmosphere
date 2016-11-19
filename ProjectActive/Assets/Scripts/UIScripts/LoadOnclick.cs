using UnityEngine;
using System.Collections;

public class LoadOnclick : MonoBehaviour {

	public GameObject LoadingImage;

	public void LoadScene(int level){

		LoadingImage.SetActive (true);
		Application.LoadLevel (level);
	}
}
