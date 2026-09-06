using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform targetDestination;
    public float speed;
    public RuntimeAnimatorController[] animCon;

    bool isAlive;
    public bool isZapped = false;
    public bool isWhooshed = false;

    GameObject immText;
    Rigidbody2D myRigid;
    Animator anim;
    SpriteRenderer spriter;

    void Awake()
    {
        myRigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        immText = transform.Find("immuneText").gameObject;
    }

    void FixedUpdate()
    {

        if (!isAlive || isZapped)
        {
            myRigid.linearVelocity = Vector2.zero;
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
        gameObject.tag = data.element;

    }
    public void ZapEnemy()
    {
        Debug.Log("zapped");
        isZapped = true;
        spriter.color = new Color(0.3f, 0.3f, 1, 1);
        StartCoroutine(ZapRoutine());
    }

    private IEnumerator ZapRoutine()
    {
        yield return new WaitForSeconds(3.5f);
        spriter.color = new Color(1, 1, 1, 1);
        isZapped = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("zap") && !collision.CompareTag("whoosh"))
        {

            StartCoroutine(textAppear());

        }
    }

    IEnumerator textAppear()
    {
        immText.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        immText.SetActive(false);

    }

}