using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                       //UI와 접근하기 위해 사용

public class ExPlayer : MonoBehaviour
{
    public int HP = 100;
    public Text TextUI = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextUI.text = HP.ToString();        //UI에 체력 표시
        if(Input.GetMouseButtonDown(0))     // 마우스 왼쪽 입력이 되었을 때 조건
        {
            HP -= 10;                       //HP = HP - 10
            if(HP <= 0)                     //체력이 0 이하가 되면 파괴한다.
            {
                TextUI.text = HP.ToString();
                Destroy(gameObject);        //gameObject는 스크립트가 붙어있는 오브젝트를 자칭
            }
        }
    }
}
