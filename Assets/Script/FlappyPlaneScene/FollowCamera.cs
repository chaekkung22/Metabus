using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] bool useClamp;
    [SerializeField] float minX, maxX, minY, maxY;
    float offsetX;
    float offsetY;
    private void Start()
    {
        offsetX = transform.position.x - target.position.x;
        if(useClamp )
        offsetY = transform.position.y - target.position.y;
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;


        if (useClamp)
        {
            pos.y = target.position.y + offsetY;
            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            pos.y = Mathf.Clamp(pos.y, minY, maxY);
        }

        transform.position = pos;
    }
}
