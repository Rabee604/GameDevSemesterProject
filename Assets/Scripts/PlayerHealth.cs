using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour

{   
    [SerializeField] private FloatSO soHealth;
    [SerializeField] 
    private PlayerHeatlhSo playerHeatlhSo;
    [SerializeField] private int maxHeath;
    [SerializeField] private Gameover gameover;
    private int currentHeath;
    public PlayerController playerController;
    [SerializeField] TimeCount timeCount;
    // Start is called before the first frame update
    
    void Start()
    {
        currentHeath = (int)soHealth.Value;
    }

    
    
    
    public void TakeDamage(int damage)
    {
        currentHeath -= damage;
        
        //Debug.Log("player1");
       
        if (currentHeath>= 0)
        {
            playerHeatlhSo.lifeManger();
            //Debug.Log("player!");


        }
        else
        {
            gameover.gameOverPage();
            disable();
            timeCount.GetComponent<TimeCount>().enabled=false;
            playerController.GetComponent<PlayerController>().enabled = false;
        }
    }


    public void disable()
    {
        
        string tag = "Enemy"; 
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject tagged in taggedObjects){
            tagged.SetActive(false);
        }
    }

}
