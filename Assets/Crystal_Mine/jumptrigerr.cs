using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class jumptrigerr : MonoBehaviour
{
    [SerializeField] private ThirdPersonController kedicik;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kedicik.JumpHeight = 1;
        }
    }
}
