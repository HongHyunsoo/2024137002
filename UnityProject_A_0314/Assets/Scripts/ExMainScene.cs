using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExMainScene : MonoBehaviour
{
    public void GoToShootGame()     //��ư ȣ�� �� �Լ� ����
    {
        SceneManager.LoadScene("GameScene_Gun");    //GameScene_Gun �̵�
    }

    public void GoToJumpGame()      //��ư ȣ�� �� �Լ� ����
    {
        SceneManager.LoadScene("GameScene_Jump");   //GameScene_Jump �̵�
    }

    public void Exit()              //��ư ȣ�� �� �Լ� ����
    {
        Application.Quit();         //���� ����
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
