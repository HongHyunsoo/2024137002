using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExRay : MonoBehaviour
{
    public Text UIText;                     //�ؽ�Ʈ ����
    public int Point;                       //����Ʈ ����
    public float checkEndTime = 30.0f;      //���� ���� �ð�
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkEndTime -= Time.deltaTime;     //�ʸ� ���������� ����

        if (checkEndTime <= 0)
        {
            PlayerPrefs.SetInt("Point", Point);         //������ ������ ���� ���� ����
            SceneManager.LoadScene("ResuitScene");      //���â���� �̵�
        }

        if (Input.GetMouseButtonDown(1))    //GetMouseButton(1) ������ ���콺 ��ư 
        {
            Ray Cast = Camera.main.ScreenPointToRay(Input.mousePosition);   //Ray�� �����ϰ� ī�޶��� ���콺 ��ġ���� Ray�� ����

            RaycastHit hit;                                                 //Ray�� ��� �浹�� ��ü�� ���� Hit�ֱ� ���� ����

            if (Physics.Raycast(Cast, out hit))                             //�浹�Ŀ� ���� hit ������� 
            {
                Debug.Log(hit.collider.gameObject.name);                    //�浹�� ������Ʈ�� �̸��� �޾ƿ´�
                Debug.DrawLine(Cast.origin, hit.point, Color.red, 2.0f);    //RayCast���� ����׷� �� �� �ְ� �ȴ� 

                if (hit.collider.gameObject.tag == "Target")                //�浹�� ������Ʈ�� TAG�̸��� Target�� ���
                {
                    Destroy(hit.collider.gameObject);                       //�ش� ������Ʈ�� �ı��Ѵ�.
                    Point += 1;                                             //�ı� �� ����Ʈ +1

                   // if (Point >= 10) DoChangeScene();                     //����Ʈ�� 10���� �ѱ�� Scene�� ��ȯ�Ѵ�.
                }
            }
            else
            {
                Point = 0;        //Miss �� ����Ʈ 0��
            }
            UIText.text = Point.ToString();     //UI�� ǥ��
        }
    }
    void DoChangeScene()                //�� ��ȯ�� ���� �Լ� ����
        {
        SceneManager.LoadScene("ResuitScene"); //ResuitScene���� ��ȯ�ȴ�.
    }
}
