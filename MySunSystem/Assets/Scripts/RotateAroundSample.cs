using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSample : MonoBehaviour
{
    
    [SerializeField] Transform _targetObject;
    [SerializeField] float _selfRotateSpeed;
    [SerializeField] float _rotationAroundSpeed;
    Vector3 _rotateVector;
    float _rotationAngle;

    void Start() 
    {
        _rotateVector = new Vector3(0, _selfRotateSpeed, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //Rotates the planets around itself
        transform.Rotate(_rotateVector * Time.deltaTime);
        //Rotates the planets around Sun 
        transform.RotateAround(_targetObject.position, Vector3.up, _rotationAroundSpeed * Time.deltaTime);
        //calculates the angle at which the object rotates
        _rotationAngle += _rotationAroundSpeed  * Time.deltaTime;
        //If the turning angle is more than 360, a turn has finished.
        if(_rotationAngle >= 360)
        {
            _rotationAngle = 0;
            Debug.Log(this.gameObject.name + ": completed cycle");
        }

    }
}
