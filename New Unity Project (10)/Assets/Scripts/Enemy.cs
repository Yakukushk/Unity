using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public GameObject gameObject;
    float randx;
    Vector2 whereToSpawn;
    private float spawnRate = 3f;
    float nextToSpawn= 0.0f;
    void Start() {
        


 }
    void Update() {
        Spawner();
    }

    void Spawner() {
        try
        {
            if (Time.time > nextToSpawn)
            {
                nextToSpawn = Time.time + spawnRate;
                randx = Random.Range(-12.3f, 12.3f);
                whereToSpawn = new Vector2(randx, transform.position.y);
                GameObject obj = Instantiate(gameObject, whereToSpawn, Quaternion.identity);
                Destroy(obj, 5f);

            }
        }
        catch { }
    }
}
