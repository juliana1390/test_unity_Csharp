using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ThirdPersonMovement : MonoBehaviour
{
    private void Start()
    {
        controller = this.transform.GetComponent<CharacterController>();
        
    }

    private CharacterController controller;

    float speed = 6f;
    private bool lockChar = false;
    
    // Update is called once per frame
    void Update(){
        if(lockChar) return;
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = (transform.right * horizontal * speed) + (transform.forward * vertical * speed);

        if (direction.magnitude >= 0.1f)
        {
            //controller.Move(direction * (speed * Time.deltaTime));
            controller.Move(direction * Time.deltaTime);
        }
    }

    public void SetStateMovement(bool state)
    {
        lockChar = state;
    }
}
