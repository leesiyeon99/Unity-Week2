using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    //���� �� ����� �� �ִ� �������� �ν��Ͻ�
    public static GameManager Instance { get { return instance; } }

    public int score;

    //public static GameManager GetInstance() // ���� get�� ����
    //{
    //    return instance;
    //}

    //public static GameManager Instance { get; private set; } // ���� �� �ٰ� ����

    //1. �� �ϳ��� �ν��Ͻ��� ����
    private void Awake()
    {
        //�̱����� �������� => ���� ���� �ν��Ͻ��� �̱�������
        if (instance == null)
        {
            instance = this;
        }
        //�̱����� �־����� => ���� ���� �ν��Ͻ��� ����
        else
        {
            Destroy(gameObject);
        }
    }
}
