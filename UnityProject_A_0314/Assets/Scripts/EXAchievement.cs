using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAchievement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AchievementManager.instance.AddProgress("����", 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AchievementManager.instance.AddProgress("�ϰ�", 1);
        }
    }
}
