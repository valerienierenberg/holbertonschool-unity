using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController characterController;
    public AudioSource footsteps_running_grass;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        footsteps_running_grass = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded == true && characterController.velocity.magnitude > 2f && footsteps_running_grass.isPlaying == false)
        {
            footsteps_running_grass.Play();
        }
    }
}
