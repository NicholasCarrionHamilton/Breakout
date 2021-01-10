using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D ball;
    public bool Game;
    public Transform Bat;
    public GameObject particle;
    public float speed;
    public Manager m;



    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!Game)
        {
            transform.position = Bat.position;
            if (m.gameOver)
            {
                return;
            }

            if (Input.GetButtonDown("Jump") && !Game)
            {
                Game = true;
                ball.AddForce(Vector2.up * speed);
            }
        }




    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bottom"))
        {
            Debug.Log("Ball hit the bottom screen");
            ball.velocity = Vector2.zero;
            Game = false;
            m.UpdateLives(-1);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.transform.CompareTag("Brick"))
        {
            BrickScript brickScript = other.gameObject.GetComponent<BrickScript>();



            brickScript.Break();

        }

    }
}

