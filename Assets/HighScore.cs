using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    public GameObject MessageGameObject;
    TextMeshProUGUI playerHighScoreText;
    [SerializeField] private FloatSO scoreSo;
    // Start is called before the first frame update
    void Start()
    {
        MessageGameObject.SetActive(false);
        updateHighScore();
        playerHighScoreText = gameObject.GetComponent<TextMeshProUGUI>();
        playerHighScoreText.text = "Game high score is: " + PlayerPrefs.GetInt("HighScore", 0).ToString()
        +" points";
        //deleteKey();
    }

    // Update is called once per frame
    void deleteKey()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
    
        
    

    void updateHighScore()
    {
        if ( scoreSo.Value> PlayerPrefs.GetInt("HighScore", 0))
        {
            int n = (int)scoreSo.Value;
            PlayerPrefs.SetInt("HighScore", n);
            MessageGameObject.SetActive(true);
            //MessageGameObject.SetActive(false);
        } 
    }


    public IEnumerable waitTime()
    {
        Debug.Log("print");
        yield return new WaitForSeconds(5);
        Debug.Log("print");
        MessageGameObject.SetActive(false);
        
    }


    public void close()
    {
        MessageGameObject.SetActive(false);
    }
}
