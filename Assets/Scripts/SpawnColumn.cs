using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColumn : MonoBehaviour
{
    float time = 0f;

    float timer = 2f;

    public GameObject columnPrefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        time += Time.deltaTime;

        if (time > timer)
        {
            Instantiate(columnPrefab, new Vector3(4f, Random.Range(-3f, 3f), 0f), Quaternion.identity);
            time = 0f;
        }

    }
}
