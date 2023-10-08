using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class jumpTrigger : MonoBehaviour
{
    [SerializeField] private ThirdPersonController character;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            character.JumpHeight = 13;
        }
    }
}
