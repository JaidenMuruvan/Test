using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    // Class = Script
    void Start()
    {
        int score; // will print both in console, unity reads code from top to bottom.
        score = 5;
        print(score);
        score = 6;
        print(score);

        float gravity = 9.8f;
        print(gravity);

        const int highscore = 100;
        print(highscore);//Cannot change a constant will bring up an error.

        int a = 5;
        int b = 6;

        print(a + b);
        print(a - b);
        print(a / b);

        float c = 5;
        float d = 6;

        Debug.Log(c / d);

        int j = 372;
        int p = 1047;

        Debug.Log(j % 2);
        Debug.Log(p % 2);

        string FirstName = "Jaiden";
        string LastName = "Muruvan";
        string greeting = "Hello" + " " + FirstName + " " + LastName;
        
        print(greeting); //The other way of doing the string and showing it in te console.
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
