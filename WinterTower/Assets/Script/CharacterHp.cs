using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CharacterHp : MonoBehaviour
{
    private TMP_Text textBox;
    
    public int HpNow = default;
    public int MaxHp = default;
    public float HpGuage = default;


    // Start is called before the first frame update
    void Start()
    {
        textBox = GameObject.Find("Hp").GetComponent<TMP_Text>();
        HpGuage = HpNow / (float)MaxHp;
        textBox.text = $"{HpNow}/{MaxHp}";
    }


}
