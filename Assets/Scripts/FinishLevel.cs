using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    
    public SceneLoader loadinglevel;
    private AudioSource levelSound;
    public Animator transition;

    private void Start()
    {
        levelSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
            
        {
            levelSound.Play();
            transition.SetTrigger("Start"); 
            Invoke("newLevel",1f);
            //loadinglevel.LoadNextLevel();

        }
    }

    private void newLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
