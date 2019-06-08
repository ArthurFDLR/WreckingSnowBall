using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{

    public GameObject Obstacles;
    private GameManager Game_manager;
    private GameObject Obstacles_TMP;
    // Start is called before the first frame update
    void Start()
    {
        Game_manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Obstacles_TMP = Instantiate(Obstacles, transform.position, Quaternion.identity, transform);
        Obstacles_TMP.name = $"Obstacles_{Game_manager.TrackNumber.ToString()}";
    }

}
