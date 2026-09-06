using UnityEngine;

public class manager : MonoBehaviour
{
    public static manager instance;
    
    public float gameTime;
    public mobPool pool;
    public player player;
    public float health = 3f;
    void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        // Time elasped
        gameTime += Time.deltaTime;

    }
}
