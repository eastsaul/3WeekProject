using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhaseControll : MonoBehaviour
{
    GameObject battlePhaseUp = default; // �˾�â �ҷ�����

    // Start is called before the first frame update
    void Start()
    {
        battlePhaseUp = GameObject.Find("Battle"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        battlePhaseUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        battlePhaseUp.SetActive(false); // ������ ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
