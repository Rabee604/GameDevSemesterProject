using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int enemyamount;
    private int currentamount;
    [SerializeField] 
    private PlayerScore playerScore;
    [SerializeField]
    public int enemyDamage;
    [SerializeField] private int enemyMaxHeath;
    public AudioClip hit;
    [SerializeField] private int amount;
    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = enemyMaxHeath;
        currentamount =1;
        amount = 5;
        enemyamount=3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enemyTakeDamage(int damage)
    {
        enemyDamage -= damage;
        currentamount++;
        
        //Debug.Log("!");
       
        if (enemyDamage >= 0)
        {
            playerScore.scoreManger();
           


        }
        else
        {


            //Destroy(gameObject);
            
                playerScore.scoreManger();
                AudioSource.PlayClipAtPoint(hit, transform.position);
                gameObject.SetActive(false);
            
                enemyamount = enemyamount - 1;
            

             GameObject Enemy = Pool.instsnce.GetPooleObj(); 
             if (Enemy != null && currentamount<amount)
            {
                Enemy.transform.position = new Vector3(-325, 71.14f, 28.9f);
                Enemy.SetActive(true);
            }
        }
    }
}
