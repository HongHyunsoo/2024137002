using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager instance;
    public List<Achievement> achievements;

    private void Awake()    
    {
        if(instance == null)                //�ν��Ͻ��� null������ üũ
        {

            instance = this;                //instance�� ������ �� �� Ŭ������� ��Ī
            DontDestroyOnLoad(gameObject);  //���� �� Ŭ������ �ִ� ������Ʈ�� �ı����� ����
        }
        else                                //�̹� �ν��Ͻ��� ������ �Ǿ�������
        {
            Destroy(gameObject);            //�ش� ������Ʈ�� �ı�!
        }
          
    }

    public void AddProgress(string achievementName, int amount)     //���� ���� ��Ȳ�� �߰��ϴ� �Լ�
    {
        Achievement achievement = achievements.Find(a => a.name == achievementName);    //�ش� �̸��� �ִ� ������ ����Ʈ���� ã�Ƽ� �����´�.
        if(achievement != null )
        {
            achievement.AddProgress(amount);        //ã�� ������ Ƚ���� ī�����Ѵ�.
        }
    }
}
