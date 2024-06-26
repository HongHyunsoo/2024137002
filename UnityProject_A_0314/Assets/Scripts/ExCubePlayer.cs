using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;              // 텍스트 UI
    public int Count = 0;                   // 마우스 클릭 카운터
    public int Power = 100;                 // 물리 힘 수치
    
    public int Point = 0;                   // 점수 수치
    public float checkTime = 0.0f;
    public float checkEndTime = 30.0f;      //게임 종료 시간
    
    public Rigidbody m_Rigidbody;           // 오브젝트의 강체

    // Update is called once per frame
    void Update()

    {
        checkEndTime -= Time.deltaTime;     //초를 지속적으로 뺀다

        if (checkEndTime <= 0)
        {
            PlayerPrefs.SetInt("Point", Point);         //게임이 끝나기 전에 점수 저장
            SceneManager.LoadScene("ResuitScene");      //결과창으로 이동
        }

        checkTime += Time.deltaTime;        // 시간을 누적해서 쌓는다. checkTime -> 0초, 1초, 0초, 1초
        if(checkTime >= 1.0f)               // 1초마다 어떤 행동을 한다.
        {
            Point += 1;                     // 1초마다 점수 1점을 올린다.
            checkTime = 0.0f;               // 시간을 초기화 한다.
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))               // 조작키 조건
        {  
            Power = Random.Range(100, 200);                 // 100 ~ 200 사이의 값의 힘을 준다
            m_Rigidbody.AddForce(transform.up * Power);     // Y축으로 설정한 힘을 준다.         
        }

        TextUI.text = Point.ToString();                     // UI 점수표시

    }

    void OnCollisionEnter(Collision collision)              // 충돌 되었을 때
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Pipe")             // 설정한 Tag가 Pipe일때 동작한다.
        {
            Point = 0;
            gameObject.transform.position = Vector3.zero;   // 플레이어를 원점으로 이동시킨다.
        }
        
    }
    private void OnTriggerEnter(Collider other)     // Trigger 통한 충돌
    {
        if(other.gameObject.tag == "Items")         // 설정한 Tag로 Items와 충돌했을 때
        {
            Point += 10;                            // Point를 10점 올려준다.
            Destroy(other.gameObject);              // 해당 오브젝트를 파괴 시켜준다.
        }
          
    }
}
