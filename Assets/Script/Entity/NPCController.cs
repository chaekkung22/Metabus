using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    Collider2D collider2D;
    PlayerController playerController;

    private void Awake()
    {
        collider2D = GetComponent<Collider2D>();
        playerController = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
