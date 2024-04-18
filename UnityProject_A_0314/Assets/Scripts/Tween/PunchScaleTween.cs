using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PunchScaleTween : MonoBehaviour
{
    public bool isPunch = false;        //플레그 값 선언

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))        //스페이스 키를 누르면
        {
            if (!isPunch)   //펀치 중이 아닐 때(펀치 중 일때는 키보드를 눌러도 효과가 들어가지 않음)
            {
                isPunch = true; //펀치 중으로 상태 값을 만든다
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunsh);
            }
        }
    }

    void EndPunsh()
    {
        isPunch = false;
    }
}
