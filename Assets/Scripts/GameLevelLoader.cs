using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider sliderBar;

    public void LoadNewLevel(int sceneNumber)
    {
        StartCoroutine(LoadLevel(sceneNumber));
        Debug.Log("Newwwwwww");

    }
    
    IEnumerator LoadLevel(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            sliderBar.value = progress;
           yield return null;
        }
        

    }
}
