using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithObject : MonoBehaviour {
    public GameObject objectToFollow;
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = objectToFollow.transform.position;
        gameObject.transform.rotation = objectToFollow.transform.rotation;
    }
}
