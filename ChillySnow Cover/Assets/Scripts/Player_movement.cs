using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    enum T_direction { Left, Forward, Right };
    private T_direction Current_direction;

    public float Movement_Speed_y;

    private float Movement_Speed_x;
    public float Max_Speed_x_base;
    public float Taux_virage_Speed;
    private float Max_Speed_x;

    public float Acceleration_x_base;
    public float Taux_virage_Acceleration;
    private float Acceleration_x;
    private Vector3 Movement_x;



    void Start()
    {
        Current_direction = T_direction.Forward;
    }

    void Update()
    {
        transform.Translate(0, -Movement_Speed_y * Time.deltaTime, 0); //Descend a la vitesse Mo._speed.

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) //Modifie la direction par Touch sur ecran
        {
            Max_Speed_x = Max_Speed_x_base;
            Acceleration_x = Acceleration_x_base;

            if ( T_direction.Left == Current_direction)
            {
                Current_direction = T_direction.Right;
            }
            else if (T_direction.Right == Current_direction)
            {
                Current_direction = T_direction.Left;
            }
            else if (T_direction.Forward == Current_direction)
            {
                Current_direction = T_direction.Left;
            }
            Debug.Log(Current_direction);
        }

        if (Input.touchCount > 0) //Virage violent
        {
            Max_Speed_x += Taux_virage_Speed * Time.deltaTime;
            Acceleration_x += Taux_virage_Acceleration * Time.deltaTime;
        }



        if ( (Current_direction == T_direction.Left) && (Movement_Speed_x > -Max_Speed_x)) //Accelere dans la direction adequat si on a pas atteint le max de vitesse
        {
            Movement_Speed_x -= Acceleration_x * Time.deltaTime;
        }
        else if ((Current_direction == T_direction.Right) && (Movement_Speed_x < Max_Speed_x))
        {
            Movement_Speed_x += Acceleration_x * Time.deltaTime;
        }

        Movement_x = new Vector3(Movement_Speed_x * Time.deltaTime, 0, 0); //MaJ position x
        transform.position = transform.position + Movement_x;


    }
}
