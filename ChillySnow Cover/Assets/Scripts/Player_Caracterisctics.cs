using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Caracterisctics : MonoBehaviour
{
    public bool Alive = true;
    public int Score = 0;

    void Start()
    {
        Alive = true;
        Score = 0;
    }

    public void IsAlive(bool state)
    {
        Alive = state;
    }

    private void Update()
    {
        if (Alive)
        {
            Score += 1;
        }

    }
}
