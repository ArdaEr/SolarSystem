using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] GameObject _meteor;
    [SerializeField] float _meteorSpawnSpeed = 3f;
    [SerializeField] float _minSpawnPoint = -60f;
    [SerializeField] float _maxSpawnPoint = 60f;

    private void Start() 
    {
        //InvokeRepeating("MeteorSpawnSpot", 1f, _meteorSpawnSpeed);
    }
    public void SpawnMeteor()
    {
        Instantiate(_meteor, MeteorSpawnSpot(), Quaternion.identity);
    }

    public Vector3 MeteorSpawnSpot()
    {
        float spawnPosX = Random.Range(_minSpawnPoint, _maxSpawnPoint);
        float spawnPosY = Random.Range(_minSpawnPoint, _maxSpawnPoint);
        float spawnPosZ = Random.Range(_minSpawnPoint, _maxSpawnPoint);
        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY,spawnPosZ);
        return spawnPosition;
        //Instantiate(_meteor, spawnPosition, Quaternion.identity);
    }
}
