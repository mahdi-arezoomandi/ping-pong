using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject Ball;
   
    private float Position;
    
   
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        clon();
        
        

    }
    private void clon()
    {
       
        Position = Random.Range(-4, 4);
        if (GameObject.FindGameObjectWithTag("Respawn")==false)
         Instantiate(Ball, new Vector2(transform.position.x, Position), transform.rotation);





    }
}
