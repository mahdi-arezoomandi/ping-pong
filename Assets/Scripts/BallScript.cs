using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D Rigidball;
    private float ballspeedX;
    private float ballspeedY;
    private float ballspeed;
    public float speed = 50;
   
   
    // Start is called before the first frame update
    void Start()
    {
        ballspeedX = Random.Range(-5, 5);
        ballspeedX = Random.Range(-5, 5);
        ballspeedY = Random.Range(-5, 5);
        
        Rigidball.AddForce(new Vector2(ballspeedX*50, ballspeedY*50));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-9||transform.position.x>9)
            GameObject.Destroy(gameObject);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidball.AddForce(new Vector2(9 * 50, ballspeed * 50));
            
        }
    }
}
