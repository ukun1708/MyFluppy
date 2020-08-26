using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBack : MonoBehaviour
{
    float time = 0f;

    public float timer = 20f;

    public GameObject columnPrefab;

    void Start()
    {

    }


    void Update()
    {
        time += Time.deltaTime;

        if (time > timer)
        {
            Instantiate(columnPrefab, new Vector3(10f, 0f, 0f), Quaternion.identity);
            time = 0f;
        }

    }
}
