using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private Animator animator;
    public manager playerHealth;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(playerHealth.health == 4)
        {
            animator.SetBool("fullhealth", true);
        }
        if(playerHealth.health == 3)
        {
            animator.SetBool("thirdhealth", true);
        }
        if (playerHealth.health == 2)
        {
            animator.SetBool("secondhealth", true);
        }
        if (playerHealth.health == 1)
        {
            animator.SetBool("onehealth", true);
        }

    }
}
