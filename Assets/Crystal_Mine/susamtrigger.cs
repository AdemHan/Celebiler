using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class susamtrigger : MonoBehaviour
{
    public GameObject door, key;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(door.gameObject);
            Destroy(key.gameObject);
            Destroy(this.gameObject);
        }
    }
}
