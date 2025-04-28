using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D Rigidball;
    private float ballspeedX;
    private float ballspeedY;
    private float ballspeeda;
    private float ballspeedb;
    private float ballspeedS;
    public float speed ;
    private bool again=true;
    private LOgicscript logic;


    // Start is called before the first frame update
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LOgicscript>();
      

    }
    
    // Update is called once per frame
    void Update()
    {
        if (again== true)
        {
            ballspeeda = Random.Range(0f, 1f);
            ballspeedb = Random.Range(0f, 1f);
            if (ballspeeda > 0.5f)
            {
                ballspeedX = 5;
                ballspeedS = Random.Range(0, 2.5f);
            }
            else
                ballspeedX = -5;
                     ballspeedS = Random.Range(0, -2.5f);
            if (ballspeedb > 0.5f)
                ballspeedY = Random.Range(2, 5);
            else
                ballspeedY = Random.Range(-5, -2);
            
            SBall(ballspeedX, ballspeedY);
            again = false;
        }
        if (transform.position.x < -9 || transform.position.x > 9)
        {
            transform.position = new Vector2(0, ballspeedS);
            Rigidball.velocity = new Vector2(ballspeedX * speed, ballspeedY * speed);
            again = true;
        }
       
    }
  
    public virtual void SBall(float x,float y)
    {
        Rigidball.velocity = new Vector2(x* speed, y* speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ptriger"))
            logic.AddEScore();
        else if (collision.CompareTag("Etriger"))
            logic.AddPScore();
    }
}
