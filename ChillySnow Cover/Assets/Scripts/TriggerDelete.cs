using UnityEngine;

public class TriggerDelete : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
        }
    }
}
