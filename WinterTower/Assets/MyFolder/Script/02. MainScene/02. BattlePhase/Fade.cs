using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image image; // 검은색화면
    public GameObject button; // 클릭할 버튼

    public void Fadebutton() // 새로만든 버튼을 클릭하면 실행하는 함수
    {
        Debug.Log("버튼클릭");
        button.SetActive(false); // 버튼을 클릭하면 버튼은 비활성화
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine() 
    {
        float fadeCount = 0; // 처음 알파값
        while (fadeCount < 1.0f) // 알파 최대값 1.0까지 반복
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f); // 0.01초마다 실행
            image.color = new Color(0, 0, 0, fadeCount); // 해당 변수값으로 알파값 지정

        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
