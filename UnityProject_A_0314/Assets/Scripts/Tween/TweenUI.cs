using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TweenUI : MonoBehaviour
{
    public float duration = 1f;     //시간 값 선언
    private Image image;            //UI Image에 접근
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();      //컴포넌트 가져오기
        image.DOFade(0f, duration);         //페이드 효과

        image.DOPlay();         //페이트 플레이
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
