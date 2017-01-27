using UnityEngine;
using System.Collections;

public class BackCommand : MonoBehaviour
{


    public GameObject closemenu;
    private int times;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetKey("up"))
        {

            times++;

           if(times<=1)
                Instantiate(closemenu, closemenu.transform.position, closemenu.transform.rotation); //user can only genrate only one close menu

           
           



        }
    }

  
            //  The code that any instance can use to cause the score to be incremented, since the playerScore variable is a Static member, all instances of this class will have access to its value regardless of what instance next updates it.
    

    public void buttons()
    {

          RaycastHit hit;

        if (Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.rotation * Vector3.forward), out hit, 500.0f)) 
          {
              if(closemenu.tag=="yes")
                Application.Quit();
       
              
              }
    
  
    }

}

