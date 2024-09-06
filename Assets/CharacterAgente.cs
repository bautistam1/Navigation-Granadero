using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAgente : MonoBehaviour
{
    public NavMeshAgent navMesh;
        public Animator anim;
    public Transform targetTR;

    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMesh.destination = targetTR.position;
        anim.SetFloat("Speed", navMesh.velocity.magnitude);
    }
}
