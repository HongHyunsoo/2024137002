using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGemItem : MonoBehaviour
{
    public GameObject ItemBox;      //아이템 박스 정의
    public float checkTime;         //시간 검사할 변수 선언


    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;                    //프레임 시간을 쌓아서 초를 검사한다.
        if(checkTime >= 2.0f)                           // 2초의 시간이 흐르면 
        {
            checkTime = 0.0f;                           //시간 초기화
            GameObject temp = Instantiate(ItemBox);     //아이템 박스 프리팹을 instantiate 로 생성한다.
            temp.transform.position = this.gameObject.transform.position;   //생성할 때 스크립트가 있는 오브젝트 위치로 생성 
            int RandomNumber = Random.Range(0, 4);                          //0에 3까지의 랜덤 값을 받아서 
            temp.transform.position += new Vector3(0.0f, RandomNumber, 0.0f);   //y 값 위치에 더해준다.
        }
    }
}
