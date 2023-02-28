using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int stageIndex;
    public GameObject[]Stages = new GameObject[4];

    public void NextStage() 
    {
        Stages[stageIndex].SetActive(false);

        stageIndex++;
        Stages[stageIndex].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Stages[1].transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        Stages[1].SetActive(false); // ������ ��Ȱ��ȭ
        //Stages[2].transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        //Stages[2].SetActive(false); // ������ ��Ȱ��ȭ
        //CardInfoUp.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
