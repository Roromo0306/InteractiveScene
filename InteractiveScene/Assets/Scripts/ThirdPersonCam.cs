using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    public Rigidbody controller;

    public float speed = 6f;


    private void Start()
    {
        
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal*speed, 0f, vertical*speed);

        controller.velocity = direction;
    }
}
