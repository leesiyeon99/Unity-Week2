using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBasic : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Start");
        StartCoroutine(TestCoroutine());
        //StopCoroutine(TestCoroutine());
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    IEnumerator TestCoroutine()
    {
        PrintColorLog("Start Coroutine");

        yield return null; //�� ������ ���� ����, ������Ʈ�� ����
        PrintColorLog("yield return null"); 

        yield return new WaitForSeconds(1f); //1�� �� ������Ʈ ������ ���
        PrintColorLog("Wait For Seconds 1sec");

        yield return new WaitForFixedUpdate(); //fixedupdate �� ���
        PrintColorLog("Wait For FixedUpdate");

        yield return new WaitForEndOfFrame(); //�� �������� ������ ���
        PrintColorLog("Wait For End Of Frame");

        yield return new WaitForSecondsRealtime(1); //���� n�ʰ� �ð� ����

        yield return new WaitUntil(() => true); //������ �����Ҷ����� ����


        PrintColorLog("End Coroutine");
        yield break;
    }

    private void PrintColorLog(string text)
    {
        Debug.Log($"<color=yellow>{text}</color>");
    }
}
