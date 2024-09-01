using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{
    public UnityEvent OnScream;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scream();
        }
    }

    private void Scream()
    {
        Debug.Log("�÷��̾ �Ҹ��� �����ϴ�.");
        OnScream.Invoke();
    }
}
