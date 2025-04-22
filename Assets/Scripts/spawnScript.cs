using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject Ball;
    private float Position;
    public float time = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Position = Random.Range(-4,4);
        clon();

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
