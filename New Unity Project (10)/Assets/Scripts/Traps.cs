using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Traps : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject pointlight;
    public GameObject pointlight2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Score.coinAmount = 0;
            Invoke("Reloading", 2f);
            Debug.Log("Trapped!");
            Static();
           // Raloading();

        }
       
    }
    [System.Obsolete]
    void Raloading()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    void Static() {
        if (!gameObject.activeSelf) {
            gameObject.SetActive(true);
            pointlight.SetActive(false);
            pointlight2.SetActive(false);
            Time.timeScale = 0f;
        }
    }

   
}
