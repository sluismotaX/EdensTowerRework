using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public int seconds;
    public string sceneName;
    private int secondsElapsed = 0;
    
    void Start()
    {
        StartCoroutine(UpdateTimer(seconds));
    }

    private IEnumerator UpdateTimer(int seconds)
    {
        while (secondsElapsed != seconds)
        {
            secondsElapsed += 1;
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene(sceneName);
    }

}
