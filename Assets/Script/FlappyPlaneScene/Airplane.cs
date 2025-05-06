using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    Animator animator;
    Rigidbody2D _rigidbody2D;

    public float flapForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;
    public bool godMode = false;

    float deathCooldown = 0f;
    bool isFlap = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isDead)
        {
            if (deathCooldown <= 0f)
            {

            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            isFlap = true;
        }


    }

    private void FixedUpdate()
    {

        if (isDead) return;

        Vector2 velocity = _rigidbody2D.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flapForce;
            isFlap = false;
        }

        _rigidbody2D.velocity = velocity;

        float angle = Mathf.Clamp(_rigidbody2D.velocity.y * 10f, -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode) return;
        if (isDead) return;


        deathCooldown = 1f;
        isDead = true;

        animator.SetBool("IsDie", true);
        GameManager.Instance.GameOver();
    }
}
