using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
     {
         //Object.SetActive(false);
     }
     ThirdPersonMovement refObject;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Destruction");
            //Destroy(gameObject);
            
            //other.gameObject.SetActive(false);
            ThirdPersonMovement rb = other.gameObject.GetComponent<ThirdPersonMovement>();
            if (rb != null)
            {
                refObject = rb;
                refObject.SetStateMovement(true);
                this.transform.GetComponent<Mission>().SetMission(this);
            }
            else
            {
                print("Ok");
            }
        }
    }

    public void UnlockMovement(){
        refObject.SetStateMovement(false);
    }
    //on trigger exit
    
    //Debug.Log();
    // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log("Hello!"); 
    // }
}


