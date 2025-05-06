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


    public Vector3 SetRandomPlace(Vector3 lastPos, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = lastPos + new Vector3(interval, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Airplane airplane = collision.GetComponent<Airplane>();
        if (airplane != null)
        {
            GameManager.Instance.AddScore(1);
        }
    }

}
