using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : BaseController
{
    StatHandler statHandler;
    AnimationHandler animationHandler;
    [SerializeField]GameObject pressE;

    protected override void Awake()
    {
        statHandler = GetComponent<StatHandler>();
        animationHandler = GetComponent<AnimationHandler>();
    }

    protected override void Update()
    {
        base.Update();
        Movement();
        animationHandler.Move(movementDirection);
    }


    protected override void HandleAction()
    {
        if (movementDirection != Vector2.zero)
            lookDirection = movementDirection;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector2(x, y).normalized;
    }

    void Movement()
    {
        transform.position += (Vector3)movementDirection * statHandler.Speed * Time.deltaTime;
    }

    void ChoiceGame()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //게임을 선택하는 UI를 띄우기
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            pressE.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            pressE.SetActive(false);
        }
    }
}
