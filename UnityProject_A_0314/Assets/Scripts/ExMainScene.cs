using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExMainScene : MonoBehaviour
{
    public void GoToShootGame()     //버튼 호출 할 함수 제작
    {
        SceneManager.LoadScene("GameScene_Gun");    //GameScene_Gun 이동
    }

    public void GoToJumpGame()      //버튼 호출 할 함수 제작
    {
        SceneManager.LoadScene("GameScene_Jump");   //GameScene_Jump 이동
    }

    public void Exit()              //버튼 호출 할 함수 제작
    {
        Application.Quit();         //게임 종료
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
