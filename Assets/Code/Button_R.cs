using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_R : MonoBehaviour
{
    public GameObject Person;
    public GameObject Trol;

    public void OnButtonClick()
    {
        // 원하는 반응을 구현 (예: 활성화, 비활성화, 이동 등)
        Person.GetComponent<Person>().MoveToTarget();
        Trol.GetComponent<Trol>().MoveToTarget();
        Debug.Log("Working");
    }
}
