using UnityEngine;

public class detectionWhoosh : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("general") && !gameObject.CompareTag("whoosh"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.KnockbackEnemy();
            }
        }
    }
}