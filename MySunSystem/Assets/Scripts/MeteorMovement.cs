using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
   
    [SerializeField] float _speedCoef;
    Rigidbody _rigid;   
    GameObject[] planets;
    GameObject targetPlanet;
    
    private void Awake() 
    {
        _rigid = GetComponent<Rigidbody>();
        planets = GameObject.FindGameObjectsWithTag("Planets");
        targetPlanet = planets[Random.Range(0, planets.Length)];
    }
    private void Start() 
    {
        _rigid.useGravity = true;
    }

    private void Update() 
    {
        Vector3 lookDirection = (targetPlanet.transform.position - transform.position).normalized;
        _rigid.AddForce(lookDirection * _speedCoef);
    }

    
}
