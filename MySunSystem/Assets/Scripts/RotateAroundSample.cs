using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSample : MonoBehaviour
{
    
    [SerializeField] Transform _targetObject;
    [SerializeField] float _rotateSpeed;
    [SerializeField] float _speedCoof;
    Vector3 _rotateVector;
    float _rotationAngle;

    void Start() 
    {
        _rotateVector = new Vector3(0, _rotateSpeed, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //Rotates the planets around itself
        transform.Rotate(_rotateVector * Time.deltaTime);
        //Rotates the planets around Sun 
        transform.RotateAround(_targetObject.position, Vector3.up, _speedCoof * Time.deltaTime);
        
    }
}
