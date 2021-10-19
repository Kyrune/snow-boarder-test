using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float invokeDelayBoop = 0.5f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadSceneBoop", invokeDelayBoop);        
        }
    }

    void ReloadSceneBoop()
    {
        SceneManager.LoadScene(0);
    }
}
