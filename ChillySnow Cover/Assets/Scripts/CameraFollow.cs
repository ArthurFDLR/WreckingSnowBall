using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject Player;
    private Vector3 Cam_Offset;
    private Vector3 Cam_pos;
    // Update is called once per frame

    private void Start()
    {
        Cam_Offset = transform.position;
    }

    void Update()
    {
        //transform.position = Player.transform.position;
        Cam_pos = new Vector3(0, Player.transform.position.y + Cam_Offset.y, Cam_Offset.z);
        transform.position = Cam_pos;
    }
}
