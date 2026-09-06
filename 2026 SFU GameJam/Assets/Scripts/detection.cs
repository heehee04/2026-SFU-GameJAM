using UnityEngine;

public class detection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("general"))
        {
            Destroy(collision.gameObject);
        }
    }
}
