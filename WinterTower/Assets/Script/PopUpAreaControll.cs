using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAreaControll : MonoBehaviour // 팝업 제어
{
    GameObject characterInfoPopUp = default; // 팝업창 불러오기

    // Start is called before the first frame update
    void Start()
    {
        characterInfoPopUp = GameObject.Find("CharacterInfoPopUp"); // 팝업창을 찾는다
        characterInfoPopUp.SetActive(false); // 시작은 비활성화
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
