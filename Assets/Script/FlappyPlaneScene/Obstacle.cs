using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float holeSizeMin = 1f;
    float holeSizeMax = 3f;

    float highPosY = 1f;
    float lowPosY = -1f;

    [SerializeField] Transform topObject;
    [SerializeField] Transform bottomObject;

    float interval = 4f;

}
