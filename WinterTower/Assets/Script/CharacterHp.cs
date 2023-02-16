using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CharacterHp : MonoBehaviour // ĳ���� Hp �ؽ�Ʈ
{
    private TMP_Text textBox; // �ؽ�Ʈ�� ��Ÿ�� ���� TMP_Text != Text

    public int HpNow = default; // ���� ü��
    public int MaxHp = default; // �ִ� ü��
    public float HpGuage = default; // ü�� ����


    // Start is called before the first frame update
    void Start()
    {
        textBox = GameObject.Find("Hp").GetComponent<TMP_Text>();
        HpGuage = HpNow / (float)MaxHp; 
        textBox.text = $"{HpNow}/{MaxHp}"; // ü�� ���� = ���� ü�� / �ִ� ü��
    }


}
