using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum enemyState
{
    IDLE,
    RUN, 
    ATTACK, 
    JUMP
}

public class EnemyBehaviour : MonoBehaviour
{
    public Animator animator;

    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        var LOS = Physics.BoxCast(transform.position, transform.forward, transform.localScale);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetInteger("AnimState", (int)enemyState.RUN);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetInteger("AnimState", (int)enemyState.IDLE);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetInteger("AnimState", (int)enemyState.ATTACK);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetInteger("AnimState", (int)enemyState.JUMP);
        }


    }
}


