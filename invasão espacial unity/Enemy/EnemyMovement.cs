using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHelth enemyHelth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHelth = GetComponent <EnemyHelth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        if(playerHealth.currentHealth > 0 && enemyHelth.currentHealth>0)
        {

            if (nav.SetDestination(player.position))
            {
                nav.SetDestination(player.position);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else
        {
            nav.enabled = false;
        }



    }
}
