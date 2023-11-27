using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    private float distanceX;
    private float distanceY;

    void Start()
    {
        distanceX = transform.position.x - player.position.x;
        distanceY = transform.position.y - player.position.y;
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos = new Vector3 (player.position.x + distanceX, player.position.y + distanceY, pos.z);
        transform.position = pos;
    }
}
