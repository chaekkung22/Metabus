using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetBool("IsMove", obj.magnitude > 0.5);
    }

    public void Damage()
    {
        animator.SetBool("IsDamage", true);
    }

    public void InvicibilityEnd()
    {
        animator.SetBool("IsDamage", false);
    }
}
