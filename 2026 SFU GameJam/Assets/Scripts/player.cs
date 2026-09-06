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

        Debug.Log(manager.instance.health);
        manager.instance.health--;
    }

    private void Update()
    {
        if (manager.instance.health <= 1)
        {
            //Gameover screen
        }
    }
}
