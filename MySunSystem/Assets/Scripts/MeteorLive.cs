using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorLive : MonoBehaviour
{
     [SerializeField] GameObject _particleExplosion;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LiveTimeMeteor());
    }
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        ParticleEffect();
    }

    void ParticleEffect()
    {
        GameObject _particle = (GameObject)Instantiate
                            (_particleExplosion, transform.position,transform.rotation);
                            Destroy(_particle, 1.5f);
    }
    IEnumerator LiveTimeMeteor()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("KAMIKAZE DIDINT WORK");
        Destroy(gameObject);
    }
}
