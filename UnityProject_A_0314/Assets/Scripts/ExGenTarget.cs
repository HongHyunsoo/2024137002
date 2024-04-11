using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExGenTarget : MonoBehaviour
{
    public GameObject Target;      //타겟 정의
    public float checkTime;         //시간 검사할 변수 선언
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;                    //프레임 시간을 쌓아서 초를 검사한다.
        if (checkTime >= 1.0f)                          // 2초의 시간이 흐르면 
        {
            checkTime = 0.0f;                           //시간 초기화
            GameObject temp = Instantiate(Target);      //아이템 박스 프리팹을 instantiate 로 생성한다.
            temp.transform.position = new Vector3(-4.0f, -4.0f, 0.0f);      //생성할 때 스크립트가 있는 오브젝트 위치로 생성 
            int RandomNumberX = Random.Range(0, 8);                         //0에 8까지의 랜덤 값을 받아서 
            int RandomNumberY = Random.Range(0, 8);
            temp.transform.position += new Vector3(RandomNumberX, RandomNumberY, 0.0f);   //x, y 값 위치에 더해준다.

            Destroy(temp, 2.0f);

        }
    }
}
