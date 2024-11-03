using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    GameObject Person_H;
    
    void staet()
    {
        this.Person_H = GameObject.Find("Person");
        Vector3 myPosition = this.Person_H.transform.position;
    }

    public void MoveToTarget()
    {
        Vector3 myPosition = this.Person_H.transform.position;
        while (myPosition.x < 50)
        {
            myPosition = this.Person_H.transform.position;
            transform.Translate(2,0,0);
        }
    }
}
