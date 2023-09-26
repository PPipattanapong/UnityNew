using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    [SerializeField] private int healthPoint = 2;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthPoint = -3;
        }
        if (healthPoint <= 0 )
        {
            Death();
        }
            
        Debug.Log("Hit");
    }
    [SerializeField] private Animator animator;

    void Start()
    {
       animator  = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Death();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetBool("death", false);
        }
    }
    private void Attack ()
    {
        animator.SetTrigger("attack");
    }
    private void Death()
    {
        animator.SetBool("death" , true);
        Destroy(gameObject);
    }
}
