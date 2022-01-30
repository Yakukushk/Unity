using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Traps : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Score.coinAmount = 0;
            Invoke("Reloading", 2f);
            Debug.Log("Trapped!");
            Raloading();
        }
    }
    [System.Obsolete]
    void Raloading()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

   
}
