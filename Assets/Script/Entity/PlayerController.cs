using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    StatHandler statHandler;

    private void Awake()
    {
        statHandler = GetComponent<StatHandler>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, y, 0).normalized;

        transform.position += move * statHandler.Speed * Time.deltaTime;

    }
}
