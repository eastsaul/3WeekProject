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
        Stages[1].transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) 와 같은 표현임, 현업에서 자주 씀
        Stages[1].SetActive(false); // 시작은 비활성화
        //Stages[2].transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) 와 같은 표현임, 현업에서 자주 씀
        //Stages[2].SetActive(false); // 시작은 비활성화
        //CardInfoUp.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
