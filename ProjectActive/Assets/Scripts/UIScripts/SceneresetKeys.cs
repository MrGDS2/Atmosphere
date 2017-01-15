using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneresetKeys : MonoBehaviour
{
    //Insert the empty game object with the TextMesh attached

    // Use this for initialization
    void Start()
    {

 Scene scene = SceneManager.GetActiveScene();
        switch (scene.name)
        {
            case "AtmosphereEASY":

                PlayerPrefs.DeleteAll();//saves player asteroids


                break;
            case "AtmosphereModerate":
                PlayerPrefs.DeleteAll();
                break;
            case "AtmosphereInsane":
                PlayerPrefs.DeleteAll();
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }


   
    }


