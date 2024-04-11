using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExResultScene : MonoBehaviour
{
    public Text TextUI;         //UI컴포넌트 받아오기

    public void Start()
    {
        TextUI.text = PlayerPrefs.GetInt("Point").ToString();   //int로 저장된 Point가져와서 ToString함수로 문자열 변환
    }
    public void GoToGame()      //버튼이 호출 할 함수 제작
    {
        SceneManager.LoadScene("MainScene");    //MainScene 이동
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
