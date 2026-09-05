using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class mobPool : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] pool;

    void Awake()
    {
        pool = new List<GameObject>[prefabs.Length];

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int i)
    {
        GameObject select = null;

        // if there is nothing in 'select', instantiate the prefabs (enemies) and add it to the pool list
        if (select == null)
        {
            select = Instantiate(prefabs[i], transform);
            pool[i].Add(select);
        }


        return select;
    }
}
