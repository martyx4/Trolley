using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Person; // 반응할 게임 오브젝트

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // 원하는 반응을 구현 (예: 활성화, 비활성화, 이동 등)
        Person.SetActive(!Person.activeSelf); // 예: 활성화/비활성화
    }
}
