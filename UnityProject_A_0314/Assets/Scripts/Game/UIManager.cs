using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text pointText;          //점수를 표시할UI
    public Text bestScoreText;      //최고 점수를 표시할UI

    void OnEnable()
    {
        GameManager.OnPointChanged += UpdatePointText;      //이벤트 등록.
        GameManager.OnBestScoreChanged += UpdateBestScoreText;  //이벤트 등록.
    }

    void OnDisable()
    {
        GameManager.OnPointChanged -= UpdatePointText;      //이벤트 삭제.
        GameManager.OnBestScoreChanged -= UpdateBestScoreText;  //이벤트 삭제.
    }

    void UpdatePointText(int newPoint)                      //함수 이벤트를 만들어서 인수를 설정
    {
        pointText.text = "Points : " + newPoint;            //점수 표시 UI 갱신
    }
    void UpdateBestScoreText(int newBestScore)              //함수 이벤트를 만들어서 인수를 설정
    {
        bestScoreText.text = "BestScore : " + newBestScore;     //최고 점수 표시 UI 갱신
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
