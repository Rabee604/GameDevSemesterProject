using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReadMe : MonoBehaviour
{
    [SerializeField] private GameObject gameScreen;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    public void SetName()
    {
        gameScreen.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        button1 = GameObject.Find("Play");
        button2 = GameObject.Find("Return");
    }
    
    public void startGame()
    
    {
        SceneManager.LoadScene(0);    
    }
    
    public void returnMain()
    
    {
        SceneManager.LoadScene(1);    
    }
        
    
}

