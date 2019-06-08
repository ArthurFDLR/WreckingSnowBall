using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject track;
    private bool Spawned;
    public float OffSet_pos_track;
    private GameObject Track_tmp;
    private GameManager Game_manager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !Spawned)
        {
            Vector3 pos = new Vector3(transform.parent.position.x, (transform.parent.position.y - OffSet_pos_track), transform.parent.position.z);

            Game_manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
            Game_manager.TrackNumber += 1;

            Track_tmp = Instantiate(track, pos, transform.parent.rotation);
            Track_tmp.name = $"SnowTrack_{Game_manager.TrackNumber.ToString()}";

            foreach (Transform t in Track_tmp.transform)    //Detruire le contenant des obstacles associes à la track precedente pour eviter les doublons lors de la nouvelle generation d'obstacles
            {
                if (t.name == $"Obstacles_{(Game_manager.TrackNumber-1).ToString()}")
                {
                    Destroy(t.gameObject);
                }
            }

            Spawned = true;
        }
    }
}
