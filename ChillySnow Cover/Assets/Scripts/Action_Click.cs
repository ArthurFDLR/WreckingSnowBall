using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Click : MonoBehaviour
{

    public GameManager Game_Manager;

    // Update is called once per frame
    public void On_click()
    {
        Game_Manager.Restart();
    }
}
