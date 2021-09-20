using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool isInverted;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if isInverted, camera should move up when mouse moves down and vice versa
        if (isInverted){
            yaw += speedH * Input.GetAxis("Mouse Y");
            pitch -= speedV * Input.GetAxis("Mouse X");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}


