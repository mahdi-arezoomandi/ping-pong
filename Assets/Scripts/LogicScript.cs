using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOgicscript : MonoBehaviour
{
    public Text Playerscore;
    public Text Enemyscore;
    private int Pscore;
    private int Escore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
