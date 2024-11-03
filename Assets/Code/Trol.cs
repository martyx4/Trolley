using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trol : MonoBehaviour
{
    public Vector3 targetPosition;

    public void MoveToTarget()
    {
        transform.Translate(2,0,0);
    }
}
