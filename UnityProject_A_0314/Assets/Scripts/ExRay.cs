using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExRay : MonoBehaviour
{
    public Text UIText;         //�ؽ�Ʈ ����
    public int Point;           //����Ʈ ����
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //GetMouseButton(1) ������ ���콺 ��ư 
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
                    
                }
            }
            else
            {
                Point = 0;        //Miss �� ����Ʈ 0��
            }
            UIText.text = Point.ToString();     //UI�� ǥ��
        }
    }
}
