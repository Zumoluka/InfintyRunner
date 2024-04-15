using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    internal static Camera main;
    [SerializeField] Transform player;
    Vector3 offset;

    internal Ray ScreenPointToRay(Vector3 mousePosition)
    {
        throw new NotImplementedException();
    }

    internal Vector3 ViewportToWorldPoint(Vector3 vector3)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
