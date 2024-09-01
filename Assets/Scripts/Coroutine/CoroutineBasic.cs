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

        yield return null; //한 프레임 다음 생성, 업데이트와 같음
        PrintColorLog("yield return null"); 

        yield return new WaitForSeconds(1f); //1초 뒤 업데이트 끝나고 재생
        PrintColorLog("Wait For Seconds 1sec");

        yield return new WaitForFixedUpdate(); //fixedupdate 후 재생
        PrintColorLog("Wait For FixedUpdate");

        yield return new WaitForEndOfFrame(); //한 프레임이 끝나고 재생
        PrintColorLog("Wait For End Of Frame");

        yield return new WaitForSecondsRealtime(1); //현실 n초간 시간 지연

        yield return new WaitUntil(() => true); //조건이 충족할때까지 지연


        PrintColorLog("End Coroutine");
        yield break;
    }

    private void PrintColorLog(string text)
    {
        Debug.Log($"<color=yellow>{text}</color>");
    }
}
