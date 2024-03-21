using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                       //UI�� �����ϱ� ���� ���

public class ExPlayer : MonoBehaviour
{
    public int HP = 100;
    public Text TextUI = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextUI.text = HP.ToString();        //UI�� ü�� ǥ��
        if(Input.GetMouseButtonDown(0))     // ���콺 ���� �Է��� �Ǿ��� �� ����
        {
            HP -= 10;                       //HP = HP - 10
            if(HP <= 0)                     //ü���� 0 ���ϰ� �Ǹ� �ı��Ѵ�.
            {
                TextUI.text = HP.ToString();
                Destroy(gameObject);        //gameObject�� ��ũ��Ʈ�� �پ��ִ� ������Ʈ�� ��Ī
            }
        }
    }
}
