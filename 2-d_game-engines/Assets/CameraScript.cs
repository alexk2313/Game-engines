using Assets; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Question[] questions = new Question[3];
   

    // Start is called before the first frame update
    void Start()
    {
        
        questions[0] = new Question("5+5 = 10", true);
        questions[1] = new Question("2+2 = 4", true);
        questions[2] = new Question("3 + 3 = 7", false);


        print("Press g for answer and for nexy question.");
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey("g"))
        {
            
        }
        
    }
}
