using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{

    private NavMeshAgent monster;
    
    public Transform PlayerTarget;
    // Start is called before the first frame update
    void Start()
    {
        monster = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        monster.SetDestination(PlayerTarget.position);
    }
}
