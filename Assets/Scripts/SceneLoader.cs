using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
   
    public float transitionTime = 1f;
    public Animator transition;
    
    // Update is called once per frame
    


    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(2));
      

    }
    public void LoadNewGame()
    {
        StartCoroutine(LoadGame(2));
        //SceneManager.LoadScene(0);
        

    }
    
    public void LoadReadMe()
    {
        StartCoroutine(LoadGame(1));
        //SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
    public void LoadQuit()
    {
        StartCoroutine(LoadGame(0));
        //SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
    
    public IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
       
        yield return null;
        //}


        //yield return new WaitForSeconds(transitionTime);
        //SceneManager.LoadScene(levelIndex);

    }


  
    
    
    IEnumerator LoadGame(int levelIndex)
    {
        transition.SetTrigger("Start");
        //wait before load scene.
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

        
    }
}
