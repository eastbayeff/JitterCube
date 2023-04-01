using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOnTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Invoke(nameof(NextLevel), 1f);
    }

    private void NextLevel()
    {
        var nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);
    }
}
