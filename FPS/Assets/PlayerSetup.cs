using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour {
    public FirstPersonMovement movement;
    public GameObject camera;
    public Jump jump;
    public Crouch crouch;
    public GameObject audio;

    public void IsLocalPlayer() {
        movement.enabled = true;
        jump.enabled = true;
        crouch.enabled = true;
        camera.SetActive(true);
        audio.SetActive(true);
    }
}

