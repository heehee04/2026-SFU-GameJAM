using UnityEngine;

public class detection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("general") && !gameObject.CompareTag("zap") && !gameObject.CompareTag("whoosh"))
        {
            Destroy(collision.gameObject);
        }
        if (gameObject.CompareTag("zap"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.ZapEnemy();
            }
        }
    }
}
