using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform targetDestination;
    [SerializeField] float speed;

    Rigidbody myRigid;

    void Awake()
    {
        myRigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 direction = (targetDestination.position - transform.position).normalized;
        myRigid.linearVelocity = direction * speed;
    }
}