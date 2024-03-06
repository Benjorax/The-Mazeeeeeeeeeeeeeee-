using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    private Transform player;
    Rigidbody rb;
    [SerializeField] float detectionDistance;
    protected float distance;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
