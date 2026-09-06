using UnityEngine;

public class spawner : MonoBehaviour
{
    // List containing the data of all the spawn points set in the editor
    public Transform[] spawnPoints;

    // List contatining multiple spawn data of each spawned enemy
    public SpawnData[] spawnData;
    public float spawnTime = 1f;


    float timer;
    int level;

    private void Awake()
    {
        spawnPoints = GetComponentsInChildren<Transform>();
    }
    private void Update()
    {
        timer += Time.deltaTime;

        //Every certain amount of time, level increases (ex. 0 -> 1 -> 2 every 10 seconds) and caps it at the amount of types of enemies
        level = Mathf.Min(Mathf.FloorToInt(manager.instance.gameTime / 20f), spawnData.Length - 1);
        //Debug.Log(level);

        // Spwan interval
        if (timer > spawnTime)
        {
            timer = 0f;
            Spawn();
        }

    }

    void Spawn()
    {
        //Accessing the manager class to initiate the Get command from the mobPool script
        GameObject enemy = manager.instance.pool.Get(0);
        // Spawn the enemy on the randomly set spawnpoints 
        enemy.transform.position = spawnPoints[Random.Range(1, spawnPoints.Length)].position;
        // Set enemy data randomly depending on what level it is at
        enemy.GetComponent<Enemy>().init(spawnData[Random.Range(0, level + 1)]);
    }
}

[System.Serializable]
public class SpawnData
{
    public int spriteType;
    public float speed;
    public string element;
}