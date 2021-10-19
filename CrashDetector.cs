using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float invokeDelayBoop = 0.5f;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground")
        {
            Invoke("ReloadSceneBoop", invokeDelayBoop);        
        }
    }

    void ReloadSceneBoop()
    {
        SceneManager.LoadScene(0);
    }
}
