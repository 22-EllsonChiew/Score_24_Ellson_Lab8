using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{

    public GameObject scoreText;
    private int score;
    public Text ScoreText;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "SpaceBar: ";
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "SpaceBar: " + score;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 1;
           
        }
       
    }
    
   
}
