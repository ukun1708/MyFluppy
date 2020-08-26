using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speedx = 14f;
    public float speedy = 5f;
    private Rigidbody2D rbb;
    public int score = 0;

    public Score scrText;
    // Start is called before the first frame update
    void Start()
    {
        rbb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 4f)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                rbb.velocity = new Vector2(0f, speedy);
            }
        }
        

        if (transform.position.y < -4f)
        {
            rbb.velocity = new Vector2(0f, speedy);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Column")
        {
            SceneManager.LoadScene(1);
        }

        

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreCount")
        {
            score++;
            scrText.SetText(score);
        }
    }

}
