using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // variables
    // double mana = 15.5;
    // float speed = 5f;
    // int health = 100;
    // string playerName = "Warrior";
    // bool isDead = false;
    // char oneChar = 'a'; // optional
    // end of main variables 

    void Start()
    {
        Player warrior = new Player(1, 2, "Khoi");
        Player archer = new Player(4, 5, "Duong");

        warrior.Info();
        archer.Info();

        warrior.Attack();

        warrior.Health = 26;

        warrior.Info();
        // warrior.SetHealth(20);
        // Debug.Log(warrior.GetHealth());
    }


    // // Coroutines
    // IEnumerator ExecuteSomething()
    // {
    //     yield return new WaitForSeconds(2f);

    //     Debug.Log("Something is executed");
    // }

    // // a function that doesn't return a value and doesn't take params
    // void CalculateTwoNumbers()
    // {
    //     float a = 10;
    //     float b = 12;
    //     float c = a + b;

    //     Debug.Log("The sum of a and b is: " + c);
    // }


    // // a function that doesn't return a value but takes params
    // void CalculateTwoNumbers(float a, float b)
    // {
    //     Debug.Log("The sum of a and b is: " + (a + b));
    // }

    // // a function that returns a value but doesn't take params
    // float ReturnTwoNumbers()
    // {
    //     return 20 + 30;
    // }


    // // a function that returns a value and takes params
    // float ReturnTwoNumbers(float a, float b)
    // {
    //     return a + b;
    // }
}