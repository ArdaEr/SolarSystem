using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomInOut : MonoBehaviour
{
    private Camera _zoomCamera;
    // Start is called before the first frame update
    void Start()
    {
        _zoomCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
   
        ZoomInOut();
    }

    void ZoomInOut()
    {
        float _scrollInput = Input.GetAxis("Mouse ScrollWheel");
        if(_zoomCamera.fieldOfView > 19 && _zoomCamera.fieldOfView < 125)
        {
            if(_scrollInput < 0 && _zoomCamera.fieldOfView < 124)
            {
                _zoomCamera.fieldOfView++;
            }
            if(_scrollInput > 0 && _zoomCamera.fieldOfView > 20)
            {
                _zoomCamera.fieldOfView--;
            }
        }
    }
}
