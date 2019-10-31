using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    public Text scoreText;
    public Text healthText;

    

    // Start is called before the first frame update

    public void Start()
    {
        scoreText.text = "Score: " + Variables.Score;
        healthText.text = "Health: " + Variables.Health;

    }
    void Awake()
    
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void playerScored()
    {
   
            Variables.Score += 5;
            scoreText.text = "Score: " + Variables.Score;
         
    }

    public void playerLosesScore()
    {
        Variables.Health -= 100;
        //Variables.Score -= 1;
        if (Variables.Health <= 0)
        {
            Variables.Health = 0;
        }
        healthText.text = "Health: " + Variables.Health;
    }
}
