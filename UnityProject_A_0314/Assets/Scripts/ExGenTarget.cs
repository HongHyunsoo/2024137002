using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExGenTarget : MonoBehaviour
{
    public GameObject Target;      //Ÿ�� ����
    public float checkTime;         //�ð� �˻��� ���� ����
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;                    //������ �ð��� �׾Ƽ� �ʸ� �˻��Ѵ�.
        if (checkTime >= 1.0f)                          // 2���� �ð��� �帣�� 
        {
            checkTime = 0.0f;                           //�ð� �ʱ�ȭ
            GameObject temp = Instantiate(Target);      //������ �ڽ� �������� instantiate �� �����Ѵ�.
            temp.transform.position = new Vector3(-4.0f, -4.0f, 0.0f);      //������ �� ��ũ��Ʈ�� �ִ� ������Ʈ ��ġ�� ���� 
            int RandomNumberX = Random.Range(0, 8);                         //0�� 8������ ���� ���� �޾Ƽ� 
            int RandomNumberY = Random.Range(0, 8);
            temp.transform.position += new Vector3(RandomNumberX, RandomNumberY, 0.0f);   //x, y �� ��ġ�� �����ش�.

            Destroy(temp, 2.0f);

        }
    }
}
