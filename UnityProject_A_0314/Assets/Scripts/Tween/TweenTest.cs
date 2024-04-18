using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;      //Do Tween 을 사용하기 위해 추가

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    //Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        //Tween 단위
        //tween = transform.DOMoveX(5, 2);        //이 오브젝트를 2초 동안 x축 5로 이동시킨다
        //transform.DORotate(new Vector3(0, 0, 180), 2);      // 이 오브젝트를 2초 동안 Z축으로 180도 회전시킨다.
        //transform.DOScale(new Vector3(2, 2, 2), 2);           //이 오브젝트를 2초 동안 Scale 2까지 키운다.

        //전체 주석 Ctrl + K + C, 주석 해제 Ctrl + K + U

        //Sequence sequence = DOTween.Sequence();           //Tween 을 이어서 순서대로 실행 시켜주는 단위
        //sequence.Append(transform.DOMoveX(5, 1));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 1));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 1));

        //transform.DOMoveX(5, 2).SetEase(Ease.OutBounce);            //Ease 옵션을 사용하여 바운스 효과 적용
        //transform.DOShakeRotation(2, new Vector3(0, 0, 90), 10, 90);     //회전을 Z축 90 강도 10, 랜덤 90으로 힘을 준다.

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(TweenEnd);  //트윈이 완료되면 Tween End 함수를 호출한다.

        sequence = DOTween.Sequence();           //Tween 을 이어서 순서대로 실행 시켜주는 단위
        sequence.Append(transform.DOMoveX(5, 1));         //Tween 실행
        sequence.SetLoops(-1, LoopType.Yoyo);             //Tween 요요형태로 반복시킨다.
    }

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
            //tween.Kill();
        }
    }
}
