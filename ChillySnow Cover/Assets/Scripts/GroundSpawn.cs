using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{

    public GameObject track;
    private bool Spawned;
    public float OffSet_pos_track;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player" && !Spawned)
        {
            Vector3 pos = new Vector3(transform.parent.position.x, (transform.parent.position.y - OffSet_pos_track), transform.parent.position.z);
            Instantiate(track.transform, pos, transform.parent.rotation);
            Spawned = true;
        }
    }
}
