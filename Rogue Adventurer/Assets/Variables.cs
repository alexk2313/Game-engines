using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Variables
{
    private static int score;
    private static int health = 200;

    public static int Score
    {
        get
        {

            return score;
        }
        set
        {
            score = value;
        }
    }

    public static int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

}
