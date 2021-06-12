using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float moveSpeed = 4f;
    [Range(2, 20)]
    bool moveRight = false;
    bool moveUpwards = true;
    public bool isSideways = true;

    private Vector3 startPos;
    public Transform target;
    void Awake()
    {
        startPos = transform.position;
    }

    void FixedUpdate()
    {

        if (isSideways)
        {
            MoveSideways();
        }
        else
        {
            MoveVertically();
        }
    }

    void MoveSideways()
    {
        float step = moveSpeed * Time.deltaTime;
        if (transform.position.x >= target.position.x)
        {
            // print("Move Left");
            moveRight = false;
        }
        else if (transform.position == startPos)
        {
            moveRight = true;
        }
        if (moveRight == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, step);
        }
        else if (moveRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    void MoveVertically()
    {
        float step = moveSpeed * Time.deltaTime;
        if (transform.position.y >= target.position.y)
        {
            // print("Move Down");
            moveUpwards = false;
        }
        else if (transform.position == startPos)
        {
            moveUpwards = true;
        }
        if (moveUpwards == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, step);
        }
        else if (moveUpwards)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

}
