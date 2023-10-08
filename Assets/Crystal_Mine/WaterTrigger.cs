using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public GameObject water;
    public GameObject ice;

    private void Start()
    {
        water.SetActive(true);
        ice.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        water.SetActive(false);
        ice.SetActive(true);
        
    }
}
