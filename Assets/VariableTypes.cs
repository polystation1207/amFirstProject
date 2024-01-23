using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 10;
        float critChance = 0.25f;
        string name = "Fred, the Abominable Snowman";
        bool isAlive = true;
        //ways of reducing health, ints and floats
        health = health - 1;
        health -= 2;
        health--;
        if (health <= 0)
        {
            isAlive = false; 
        }
        // how to see if a value if exactly equal
        if(health == 0)
        {
            isAlive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
