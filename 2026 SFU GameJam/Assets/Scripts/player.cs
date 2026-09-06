using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Progress;

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
        if (manager.instance.health <= 0)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
