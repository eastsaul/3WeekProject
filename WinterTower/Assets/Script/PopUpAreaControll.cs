using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAreaControll : MonoBehaviour // �˾� ����
{
    GameObject characterInfoPopUp = default; // �˾�â �ҷ�����

    // Start is called before the first frame update
    void Start()
    {
        characterInfoPopUp = GameObject.Find("CharacterInfoPopUp"); // �˾�â�� ã�´�
        characterInfoPopUp.SetActive(false); // ������ ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
