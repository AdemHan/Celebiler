using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortriger : MonoBehaviour
{
    public GameObject yok;
    public GameObject war;

    private void Start()
    {
        yok.SetActive(true);
        war.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        yok.SetActive(false);
        war.SetActive(true);

    }
}
