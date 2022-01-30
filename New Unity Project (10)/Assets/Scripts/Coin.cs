using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject obj;
    [SerializeField] private float time = 2f;
    [SerializeField] private float spawn;
     void Start()
    {
        //StartCoroutine(inst());
        InvokeRepeating("Inst", time, spawn);
    }
     void Inst()
    {
        GameObject gameObject = Instantiate(obj, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f), Quaternion.identity);
        Destroy(gameObject, 5f);
    }
    IEnumerator inst() {
        while (true) {
            GameObject gameObject = Instantiate(obj, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f), Quaternion.identity);
            yield return new WaitForSeconds(time);
            Destroy(gameObject, 3f);
        }
    }

   
}
