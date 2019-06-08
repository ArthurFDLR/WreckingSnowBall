using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{


    public GameObject Obstacle;
    public float Min_x, Max_x;
    public float Min_y, Max_y;
    public float BlankDistance;

    private float PosX, PosY;
    private GameObject Tree;
    private GameManager Game_Mananger;

    // Start is called before the first frame update
    void Start()
    {
        Game_Mananger = GameObject.Find("Game Manager").GetComponent<GameManager>();

        Game_Mananger.Obstacle_number = 10 * (Game_Mananger.TrackNumber + 1); // Definie le nombre d'obstacle a spawn en fonction du nbr de track

        if (Game_Mananger.TrackNumber == 0)
        {
            for (int i = 0; i < Game_Mananger.Obstacle_number; i++)
            {
                PosX = Random.Range(Min_x, Max_x);
                PosY = Random.Range(transform.position.y + Min_y, transform.position.y + Max_y - BlankDistance);
                Vector3 pos = new Vector3(PosX, PosY, 0);
                Tree = Instantiate(Obstacle, pos, Quaternion.identity, transform);
                Tree.name = $"Tree_{i.ToString()}";
            }
        }
        else
        {
            for (int i = 0; i < Game_Mananger.Obstacle_number; i++)
            {

                PosX = Random.Range(Min_x, Max_x);
                PosY = Random.Range(transform.position.y + Min_y, transform.position.y + Max_y);
                Vector3 pos = new Vector3(PosX, PosY, 0);
                Tree = Instantiate(Obstacle, pos, Quaternion.identity, transform);
                Tree.name = $"Tree_{i.ToString()}";
            }
        }

    }
}
