using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : BaseController
{
    Collider2D _collider2D;
    Transform target;

    protected override void Awake()
    {
        base.Awake();
        _collider2D = GetComponent<Collider2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    protected override void Update()
    {
        lookDirection = DirectionToTarget();
        base.Update();
    }

    protected Vector2 DirectionToTarget()
    {
        return (target.position - transform.position).normalized;
    }
}
