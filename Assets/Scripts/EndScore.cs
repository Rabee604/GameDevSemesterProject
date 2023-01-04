using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    TextMeshProUGUI playerScoreText;
    [SerializeField] private FloatSO scoreSo;
    private int playerScore;
    
    // Start is called before the first frame update
    void Start()
    {
        playerScoreText = gameObject.GetComponent<TextMeshProUGUI>();
        playerScoreText.text = "Your score is: " + scoreSo.Value.ToString() + " points";
    }

    // Update is called once per frame
    
    public void scoreManger()
    {
        scoreSo.Value++;
        playerScoreText.text = scoreSo.Value.ToString();
      
    }

}
