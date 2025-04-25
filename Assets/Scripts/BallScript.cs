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
    public float speed ;
   



    // Start is called before the first frame update
    void Start()
    {
        ballspeeda =Random.Range(0f,1f);
        ballspeedb = Random.Range(0f, 1f);
        if (ballspeeda > 0.5f)
            ballspeedX = 5;
        else
            ballspeedX = -5;
        if (ballspeedb > 0.5f)
            ballspeedY = Random.Range(2, 5);
        else
            ballspeedY = Random.Range(-5, -2);

        SBall(ballspeedX, ballspeedY);
               
       
      

    }
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-9||transform.position.x>9)
            Destroy(gameObject);
        
    }
  
    public virtual void SBall(float x,float y)
    {
        Rigidball.velocity=new Vector2(x * speed, y * speed);
    }
}
