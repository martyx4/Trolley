using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public Vector3 targetPosition;

    public void MoveToTarget()
    {
        transform.position = targetPosition;
    }
}
