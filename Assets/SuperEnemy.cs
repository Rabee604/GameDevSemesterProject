using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SuperEnemy : MonoBehaviour
{
    private float enemiesDistancing;
     private int numberspot;
    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private Animator animator;
    private NavMeshAgent navMeshAgent;
    private int number;
    [SerializeField] 
    private PlayerController playerController;
    [SerializeField] 
    private float agentSuperSpeed; 
    [SerializeField] 
    private GameObject player;
    [SerializeField] GameObject[] patrolPoints;
    [SerializeField] 
    private GameObject [] playSpots;
    [SerializeField] SuperEnemy[] alleSuperEnemies;
    public bool isPatrol;

   // Start is called before the first frame update


    

    void Start()
    {
        numberspot = 0;
        number = 0;
        isPatrol = true;
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        // we make the position of the agent in point 0
        navMeshAgent.destination = patrolPoints[number].transform.position;
        animator.SetFloat("EnemyS", 0.5f);
        agentSuperSpeed = 6;
    }

    // Update is called once per frame
    void Update()

    {
        if (isPatrol)
        {
            float chase = Vector3.Distance(player.transform.position, this.transform.position);
            if (chase <= 11f && chase > 4f)
            {
                enemies();
                run();
                navMeshAgent.SetDestination(player.transform.position);


                animator.SetFloat("EnemyS", 1, 0.1f, Time.deltaTime);
                animator.SetBool("Attack", false);

            }

            float attack = Vector3.Distance(player.transform.position, this.transform.position);
            if (attack <= 2f)
            {
                nextspots();
                animator.SetBool("Attack", true);

            }
            

            float chase1 = Vector3.Distance(player.transform.position, this.transform.position);
            if (chase1 > 11f )
            {
                // go back to patrol
                navMeshAgent.SetDestination(patrolPoints[number].transform.position);
                animator.SetFloat("EnemyS", 0.5f);
                animator.SetBool("Attack", false);
            }



            if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 1)
            {
                nextpoint();
                navMeshAgent.speed = 5;
                animator.SetFloat("EnemyS", 0.5f);
                animator.SetBool("Attack", false);

            }
        }

        if (!isPatrol)
        {
            if (enemiesDistance())
            {
                enemies();
                

                if (enemiesDistanceAttack())
                {
                    Debug.Log("Attacking");
                    enemies();
                    //nextspots();
                    animator.SetBool("Attack", true);
                   
                }
                
            }
            else
            {
                isPatrol = true;
            }
        }
    }

    public void nextpoint()
    {
        navMeshAgent.destination= patrolPoints[number].transform.position;
        number = (number + 1) % patrolPoints.Length;
    }

    public void run()
    {
        navMeshAgent.speed = agentSuperSpeed;

    }
    
    
    
    public void nextspots()
    {
       
        navMeshAgent.destination = playSpots[numberspot].transform.position;
        animator.SetTrigger("Attack");
        numberspot = (numberspot + 1) % playSpots.Length;
    }

    public void enemies()
    {
        foreach (SuperEnemy e in alleSuperEnemies)
        {
            if(e.navMeshAgent.isActiveAndEnabled)
            {
                e.isPatrol = false;
                e.navMeshAgent.SetDestination(playSpots[numberspot].transform.position);
                e.navMeshAgent.transform.LookAt(player.transform.position);
                numberspot = (numberspot + 1) % playSpots.Length;
               
            }
        }
    }

    public bool enemiesDistance()
    {
        for (int i = 0; i < alleSuperEnemies.Length; i++)
        {
            if ( Vector3.Distance(player.transform.position, alleSuperEnemies[i].transform.position) <=11f)
                
            {
                return true;
            }

        }

        return false;
    }
    
    public bool enemiesDistanceAttack()
    {
        for (int i = 0; i < alleSuperEnemies.Length; i++)
        {
            if ( Vector3.Distance(player.transform.position, alleSuperEnemies[i].transform.position) <=2f)
                
            {
              
                return true;
            }

        }

        return false;
    }
    
    
}
