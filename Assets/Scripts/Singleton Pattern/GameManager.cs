using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    //게임 내 사용할 수 있는 전역적인 인스턴스
    public static GameManager Instance { get { return instance; } }

    public int score;

    //public static GameManager GetInstance() // 위의 get과 같음
    //{
    //    return instance;
    //}

    //public static GameManager Instance { get; private set; } // 위의 두 줄과 같음

    //1. 단 하나의 인스턴스를 보장
    private void Awake()
    {
        //싱글톤이 없었으면 => 지금 만든 인스턴스를 싱글톤으로
        if (instance == null)
        {
            instance = this;
        }
        //싱글톤이 있었으면 => 지금 만든 인스턴스를 삭제
        else
        {
            Destroy(gameObject);
        }
    }
}
