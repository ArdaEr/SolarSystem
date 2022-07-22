using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeBeforeRotate = 2f;
    [SerializeField] private Transform rotateAround;
    [SerializeField] Camera _camera;
    [SerializeField] private bool playerIdling = true; 
    private float lastTimeNotIdle;
 
    void Start()
    {
        lastTimeNotIdle = Time.realtimeSinceStartup; // initialize at "now"
    }

    void Update()
    {
        
        if (!isIdle()) // Check if the player is idle
        {
            // When we are not idling, update the time of last non-idle action
            lastTimeNotIdle = Time.realtimeSinceStartup;
        }
 
        // Calculate how long we are idling
        float diff = Time.realtimeSinceStartup - lastTimeNotIdle;
 
        // Only rotate when we waited timeBeforeRotate seconds after the last user action
        if (diff > timeBeforeRotate)
        {
            _camera.transform.RotateAround(rotateAround.position, Vector3.up, speed);
        }
    }
 
    private bool isIdle()
    {
        if(Input.anyKey) // checks if any key pressed
        {
            return playerIdling = false;
        }
        
        else 
        {
            return playerIdling = true;
        }
    }

   
    private bool CheckHorizantalMouseMovement()
    {
        float _horizontal = Input.GetAxis("Mouse X");
        _horizontal = Mathf.Abs(_horizontal);
        return _horizontal > 0;
    }


    private bool CheckVerticalMouseMovement()
    {
        float _vertical = Input.GetAxis("Mouse Y");
        _vertical = Mathf.Abs(_vertical);
        return _vertical > 0;
    }
}

