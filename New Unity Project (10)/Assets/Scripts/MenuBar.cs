
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBar : MonoBehaviour
{
  
    public void Start_Game() {
        try
        {
            SceneManager.LoadScene(1);
            Debug.Log("Start");
        }
        catch  {
            Debug.Log("Error");
        }
        }
   public  void Exit_Game() {
        try
        {
            Application.Quit();
            Debug.Log("Quit!");
        }
        catch {
            Debug.Log("Error");
        }
        }

}
