using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Distroy : MonoBehaviour
{
    public SceneLoader loadinglevel;
    private AudioSource levelSound;
    public Animator transition;
    [SerializeField] 
    private PlayerController playerController;
    private void Start()
    {
        levelSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "EndGame")
        {
            if (playerController.attacking)
            {

                //levelSound.Play();
                transition.SetTrigger("Start");
                Invoke("newLevel", 1f);
                
            }
        }
    }

    private void newLevel()
    {
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
