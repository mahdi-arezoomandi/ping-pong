using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class spawnScript : MonoBehaviour
{
    public GameObject Ball;
    private float Position;
    [Header("audioSource")]
    public AudioSource sound;
    [Header("audioClip")]
    public AudioClip sfx; 
    
   
    
   
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
