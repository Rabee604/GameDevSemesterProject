using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{ 
    TextMeshProUGUI playerScoreText; 
    TextMeshProUGUI playerlifeText;
    [SerializeField] private FloatSO scoreSo;
    
    private int playerScore;
   [SerializeField]
    private int playerlife;
    // Start is called before the first frame update
    void Start()
    {
        playerScoreText = gameObject.GetComponent<TextMeshProUGUI>();
        playerlifeText = gameObject.GetComponent<TextMeshProUGUI>();
        playerScoreText.text = scoreSo.Value.ToString();
    }

    // Update is called once per frame
    
    public void scoreManger()
   {
       scoreSo.Value++;
       Debug.Log( scoreSo.Value);
        playerScoreText.text = scoreSo.Value.ToString();
      
    }
    
   
    
   
}
