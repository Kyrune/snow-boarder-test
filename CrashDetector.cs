using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float invokeDelayBoop = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadSceneBoop", invokeDelayBoop);        
        }
    }

    void ReloadSceneBoop()
    {
        SceneManager.LoadScene(0);
    }
}
