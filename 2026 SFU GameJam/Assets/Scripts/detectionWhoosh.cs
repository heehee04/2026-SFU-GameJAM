using UnityEngine;

public class detectionWhoosh : MonoBehaviour
{
    float knockbackForce = 10;
    Vector2 playerTransform = new Vector2(0,0);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("general"))
        {
            Rigidbody2D rb = collision.attachedRigidbody;
            //Vector2 pushDirection = (transform.position - collision.transform.position).normalized;
            //rb.AddForce(pushDirection * 10f, ForceMode2D.Impulse);
            //rb.linearVelocity = -rb.linearVelocity;

            Vector2 direction = transform.position = (playerTransform).normalized;
            rb.linearVelocity = direction * knockbackForce;
            Debug.Log("knockback applied");
        }
    }
}