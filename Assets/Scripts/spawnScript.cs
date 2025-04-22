using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject Ball;
    public Rigidbody2D BallRigid;
    private float Position;
    private float SpeedBall;
    public float time = 0;
    private bool Ballisalive=false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       SpeedBall = Random.Range(-4, 4);
        Position = Random.Range(-4,4);
        clon();
        if (Ball.transform.position.x < -9 || Ball.transform.position.x > -9)
            GameObject.Destroy(Ball);
        BallRigid.AddForce(new Vector2(SpeedBall, 0f));

    }
    private void clon()
    {

        if (time < 3)
            time = time + Time.deltaTime;
        else
        {
            Instantiate(Ball, new Vector2(transform.position.x, Position), transform.rotation);
            time = 0;
        }

    }
}
