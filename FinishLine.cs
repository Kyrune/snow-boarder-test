using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float invokeDelay = 0.5f;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            Invoke("ReloadScene", invokeDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
