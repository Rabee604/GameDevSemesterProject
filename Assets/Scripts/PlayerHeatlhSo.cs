using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHeatlhSo : MonoBehaviour
{ 
    
    TextMeshProUGUI playerlifeText;
    [SerializeField] private FloatSO healthSo;
    private int playerScore;
   [SerializeField]
    private int playerlife;
    // Start is called before the first frame update
    void Start()
    {
        playerlifeText = gameObject.GetComponent<TextMeshProUGUI>();
        playerlifeText.text = healthSo.Value.ToString();
    }

    // Update is called once per frame
    
   
    
   public void lifeManger()
   {
      
       healthSo.Value--;
       playerlifeText.text = healthSo.Value.ToString();
   }
    
   
}
