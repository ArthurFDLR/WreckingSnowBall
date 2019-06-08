using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Display : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Player_Caracterisctics Player;

    private GameManager Game_Manager;

    private void Start()
    {
        Game_Manager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }
    void Update()
    {
        text.text = $"{Player.Score.ToString()}";
    }
}
