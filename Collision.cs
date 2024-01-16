using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
 

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "long_metal_spike_01")
        {
            // Call a method to handle game over
            GameOver();
        }
    }

    void GameOver()
    {
        
        ReloadScene();
    }

    void ReloadScene()
    {
       
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

       
        SceneManager.LoadScene(currentSceneIndex);
    }
}

