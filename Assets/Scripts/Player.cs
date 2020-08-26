using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedx = 14f;
    public float speedy = 5f;
    private Rigidbody2D rbb;
    // Start is called before the first frame update
    void Start()
    {
        rbb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbb.velocity = new Vector2(0f, speedy);
        }
    }
}
