using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LOgicscript : MonoBehaviour
{
    public Text Playerscore;
    public Text Enemyscore;
    private int Pscore;
    private int Escore;
    public GameObject Win;
    public GameObject Lose;
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
        if (Pscore == 10)

            Win.SetActive(true);
        else if (Escore == 10)
            Lose.SetActive(true);
    }
    public void AddPScore()
    {
        Pscore = Pscore + 1;
        Playerscore.text = Pscore.ToString();
    }
    public void AddEScore()
    {
        Escore =Escore+ 1;
        Enemyscore.text = Escore.ToString();
    }
    public void Tryagain()
    {
        SceneManager.LoadScene("SampleScene");
    }
        
    public void Playsfx()
    {
        sound.PlayOneShot(sfx);
    }
   public void exit()
    {
        Application.Quit();

    }
    
}
