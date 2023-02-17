using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Icons;

public class GuageSystem : MonoBehaviour
{
    private Image frontGuage;

    public int guageNow = default;
    public int maxGuage = default;
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
        guageNow = EnemyInfo.monsterHp;
        maxGuage = EnemyInfo.monsterMaxHp;

        guageControll = guageNow / (float)maxGuage;
        frontGuage.fillAmount= guageControll;
    }
}
