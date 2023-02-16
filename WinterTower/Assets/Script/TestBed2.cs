using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AbillCrontroll2 : MonoBehaviour // �÷��̾� ���� �˾�
{
    // �÷��̾��� ������ �޾ƿ�
    //public static int attackCall = default;
    //public static int defanceCall = default;
    //public static int criticalCall = default;
    //public static int avoidCall = default;

    private TMP_Text atkTxt = default;
    private TMP_Text dfTxt = default;
    private TMP_Text crTxt = default;
    private TMP_Text avTxt = default;

    private void Awake()
    {
        // ����Ƽ ������ ����Ŭ Ư���� OnEnable() �� Start() ���� ���� �ѹ� ���� ������
        // ���� �޼��� [ Object reference not set to an instance of an object ] �� ���´�
        // �׷��� ** �� Awake()�� �Ű��ش�
        // �̷��� �������� �����ص� �ȴ�
    }

    // Start is called before the first frame update
    void Start() // �� ó�� �� ��
    {
        //attackCall = PlayerInfo.attack;
        //defanceCall = PlayerInfo.defance;
        //criticalCall = PlayerInfo.critical;
        //avoidCall = PlayerInfo.avoid;

        atkTxt = GameObject.Find("ATKtxt").GetComponent<TMP_Text>(); //**
        dfTxt = GameObject.Find("DFtxt").GetComponent<TMP_Text>();
        crTxt = GameObject.Find("CRtxt").GetComponent<TMP_Text>();
        avTxt = GameObject.Find("AVtxt").GetComponent<TMP_Text>(); //**


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable() // ���� �� ���� [����Ƽ �Լ�]
    {
        if (atkTxt != null && dfTxt != null && crTxt != null && avTxt != null)
        {
            atkTxt.text = $"{PlayerInfo.attack}";
            dfTxt.text = $"{PlayerInfo.defance}";
            crTxt.text = $"{PlayerInfo.critical}%";
            avTxt.text = $"{PlayerInfo.avoid}%";
        }

    }
}