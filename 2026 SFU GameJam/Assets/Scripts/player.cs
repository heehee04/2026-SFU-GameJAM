using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;
using System.Collections.Generic;

public class player : MonoBehaviour
{
    public List<Image> hearts;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(hearts[0]);
        hearts.RemoveAt(0);
        Destroy(collision.gameObject);

    }
}
