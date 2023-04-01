using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnCollision : MonoBehaviour
{
    void OnCollisionEnter()
    {
        // Do crash stuff
        GetComponent<PlayerController>().enabled = false;
        Camera.main.transform.parent = null;
        MusicManager.Instance.PlayCrashSound();

        Invoke(nameof(Reset), 1f);
    }

    private void Reset()
    {
        var currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
