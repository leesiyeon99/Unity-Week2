using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //게임 어디에서든지 게임매니저 사용방법
            GameManager.Instance.score++;
        }
    }
}
