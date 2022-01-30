using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinPicker : MonoBehaviour
{
    private AudioSource source;
    private void OnTriggerEnter2D(Collider2D other)
    {
        try
        {
            if (other.transform.tag == "Coin")
            {
                
                Score.coinAmount += 1;
                Destroy(other.gameObject);
                source.Play();
                Debug.Log("Pick up");
                
                if (Score.coinAmount >= 20) {
                    SceneManager.LoadScene(0);
                }
            }
        }
        catch { }
        }
        
}
