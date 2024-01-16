using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;

    private bool isPaused = false;

    void Start()
    {
        if (pause != null)
            pause.SetActive(false);

        var imageCollider = GetComponent<Collider2D>();
        if (imageCollider != null)
        {
            imageCollider.isTrigger = true;
            imageCollider.gameObject.AddComponent<ButtonCollider>();
        }
    }

    public void TogglePause() // Change access modifier to public
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0f : 1f;

        if (pause != null)
            pause.SetActive(isPaused);
    }
}

public class ButtonCollider : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject.FindObjectOfType<Pause>().TogglePause();
    }
}