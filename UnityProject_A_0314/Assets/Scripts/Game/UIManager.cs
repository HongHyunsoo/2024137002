using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text pointText;          //������ ǥ����UI
    public Text bestScoreText;      //�ְ� ������ ǥ����UI

    void OnEnable()
    {
        GameManager.OnPointChanged += UpdatePointText;      //�̺�Ʈ ���.
        GameManager.OnBestScoreChanged += UpdateBestScoreText;  //�̺�Ʈ ���.
    }

    void OnDisable()
    {
        GameManager.OnPointChanged -= UpdatePointText;      //�̺�Ʈ ����.
        GameManager.OnBestScoreChanged -= UpdateBestScoreText;  //�̺�Ʈ ����.
    }

    void UpdatePointText(int newPoint)                      //�Լ� �̺�Ʈ�� ���� �μ��� ����
    {
        pointText.text = "Points : " + newPoint;            //���� ǥ�� UI ����
    }
    void UpdateBestScoreText(int newBestScore)              //�Լ� �̺�Ʈ�� ���� �μ��� ����
    {
        bestScoreText.text = "BestScore : " + newBestScore;     //�ְ� ���� ǥ�� UI ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
