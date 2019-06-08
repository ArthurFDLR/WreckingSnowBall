using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_collision : MonoBehaviour
{
    private GameObject Game_manager;
    private Player_Caracterisctics Player;

    private void OnTriggerEnter2D(Collider2D CollisionInfo)
    {
        if (CollisionInfo.CompareTag("Player"))
        {
            Game_manager = GameObject.Find("Game Manager");
            Player = GameObject.Find("Player").GetComponent<Player_Caracterisctics>();

            Game_manager.GetComponent<GameManager>().PlayerDied();
            Player.IsAlive(false);
            Debug.Log(Game_manager.GetComponent<GameManager>().TrackNumber.ToString());
        }
    }
}