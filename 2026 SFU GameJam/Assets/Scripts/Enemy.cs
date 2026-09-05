using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform targetDestination;
    public float speed;
    public RuntimeAnimatorController[] animCon;

    bool isAlive;

    Rigidbody2D myRigid;
    Animator anim;
    SpriteRenderer spriter;

    void Awake()
    {
        myRigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {

        if (!isAlive)
        {
            return;
        }

        Vector2 direction = (targetDestination.position - transform.position).normalized;
        myRigid.linearVelocity = direction * speed;
    }
    void LateUpdate()
    {
        if (!isAlive)
        {
            return;
        }

        spriter.flipX = targetDestination.position.x > transform.position.x;
    }

    private void OnEnable()
    {
        targetDestination = manager.instance.player.GetComponent<Rigidbody2D>().transform;
        isAlive = true;

    }
    public void init(SpawnData data)
    {
        anim.runtimeAnimatorController = animCon[data.spriteType];
        speed = data.speed;

    }
}