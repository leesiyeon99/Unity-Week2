using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //���� ��𿡼����� ���ӸŴ��� �����
            GameManager.Instance.score++;
        }
    }
}
