using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HpGuage : MonoBehaviour
{
    private Image frontGuage;

    public int hpNow = default;
    public int maxHp = default;
    public float guageControll = default;

    // Start is called before the first frame update
    void Start()
    {
        frontGuage = transform.GetComponent<Image>();
                     //GameObject.Find("GuageFront").GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        guageControll = hpNow / maxHp;
        frontGuage.fillAmount= guageControll;
    }
}
