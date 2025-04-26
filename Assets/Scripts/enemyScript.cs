using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
   public Transform target;
    public Rigidbody2D target2;
    public Vector2 s;
    public float spead;
   
   

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { 
    }
    private void FixedUpdate()
    {
        s = new Vector2(transform.position.x, target.position.y);
        if (target.position.y < 3.7f || target.position.y > -3.7f)
        {
            transform.position = Vector2.MoveTowards(transform.position, s, spead * Time.deltaTime);
        }
    }
}
