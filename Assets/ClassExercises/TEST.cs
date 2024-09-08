using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour


{
    new string name = "Mario";


    int a = 8;
    int b = 12;

    int playerScore = 8;

    public int var = 7;

    int variable = 2;

    int loopnum = 0;



    // Start is called before the first frame update
    void Start()
    {

        if (name == "Mario")
        {
            Debug.Log("Hello Mario");



        }
        else
        {
            Debug.Log("Hey Stranger");
        }


        if (a > b)
        {
            Debug.Log("A is greater than B!");
        }


        if (var == 8)
        {
            print("Number = 8");
        }
        else if (var < 8)
        {
            print("Number smaller than 8");
        }
        else
        {
            print("Number bigger than 8");

        }


        if (playerScore >= 0 && playerScore <= 2)
        {
            print("You suck at this game!");
        }
        else if (playerScore >= 3 && playerScore <= 4)
        {
            print("You are OK at this game!");
        }
        else if (playerScore >= 5 && playerScore <= 6)
        {
            print("You are good at this game!");
        }
        else if (playerScore >= 7 && playerScore <= 10)
        {
            print("You are great at this game!");
        }

        switch (name)
        {
            case "Mario":
                print("Hello Mario");
                break;
            default:
                print("Hello Stranger");
                break;
        }

        switch (variable)
        {
            case 1:
                print("One");
                break;
            case 2:
                print("Two");
                break;
            case 3:
                print("Three");
                break;
            case 4:
                print("Four");
                break;
            case 5:
                print("Five");
                break;
            default:
                print("IDK");
                break;

        }

        switch (playerScore)
        {
            case 0:
            case 1:
            case 2:

                print("You suck at this game!");
                break;

            case 3:
            case 4:
                print("You are OK at this game!");
                break;

            case 5:
            case 6:
                print("You are OK at this game!");
                break;

            case 7:

            case 8:
            case 9:
            case 10:
                print("You are great at this game!");
                break;



        }

        int[] nums = { 1, 2, 3, 4, 5 };
        print(nums[0]);
        nums[0] = 7;

        string[] names = { "Finn", "Jake", "Fiona", "Marceline" };
        print(names[0]);
        print(names[1]);
        print(names[2]);
        print(names[3]);

        string message = "Hello, my name is" + names[3];
        Debug.Log(message);

        while (loopnum < 10)
        {
            loopnum++;
        }

        print(loopnum);//should print 10

        string[] Names = { "Mario", "Luigi", "Toad" };
        

        for (int i = 0; i < 3; i++)
        {
            print(Names[i]);
        }

        string[] Back = { "Mario", "Luigi", "Toad" };

        for (int k = 2; k >=0; k--)
        {
            Debug.Log(Back[k]);
        }

        int[] ammo = { 30, 20, 25 };

        print(ammo[0]);
        print(ammo[1]);
        print(ammo[2]);

        int ammoLength = ammo.Length;
        int count = 0;

        while (count < ammoLength)
        {
            print(ammo[count]);
            count++;
        }

        int[] ammor = { 30, 10, 25 };

        for(int i = 0; i <ammor.Length; i++)
        {
            print(ammor[i]);
        }

        int[] amorarr = { 30, 10, 25 };

        foreach (int x in ammor)
        {
            print(x); //can use x, use any name in place of x, should relate to what is inside of array that your are targeting.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
