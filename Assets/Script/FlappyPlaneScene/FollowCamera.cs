using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    float offsetX;
    private void Start()
    {
       offsetX =  transform.position.x - target.position.x;
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;
    }
}
