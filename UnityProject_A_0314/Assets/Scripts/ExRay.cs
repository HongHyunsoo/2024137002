using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExRay : MonoBehaviour
{
    public Text UIText;         //텍스트 정의
    public int Point;           //포인트 정의
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //GetMouseButton(1) 오른쪽 마우스 버튼 
        {
            Ray Cast = Camera.main.ScreenPointToRay(Input.mousePosition);   //Ray를 정의하고 카메라의 마우스 위치에서 Ray를 쓴다

            RaycastHit hit;                                                 //Ray를 쏘고 충돌할 물체의 값을 Hit넣기 위한 정의
                
            if (Physics.Raycast(Cast, out hit))                             //충돌후에 값이 hit 있을경우 
            {
                Debug.Log(hit.collider.gameObject.name);                    //충돌한 오브젝트의 이름을 받아온다
                Debug.DrawLine(Cast.origin, hit.point, Color.red, 2.0f);    //RayCast선을 디버그로 볼 수 있게 된다 

                if (hit.collider.gameObject.tag == "Target")                //충돌한 오브젝트의 TAG이름이 Target일 경우
                {
                    Destroy(hit.collider.gameObject);                       //해당 오브젝트를 파괴한다.
                    Point += 1;                                             //파괴 시 포인트 +1
                    
                }
            }
            else
            {
                Point = 0;        //Miss 시 포인트 0점
            }
            UIText.text = Point.ToString();     //UI에 표시
        }
    }
}
