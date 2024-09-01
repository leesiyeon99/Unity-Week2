using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Coroutine cubeCoroutine;
    WaitForSeconds delay;
    [SerializeField] float coroutineDelay;

    private void Awake()
    {
        Init();
    }
    private void Init()
    {
        delay = new WaitForSeconds(coroutineDelay);
        cubeCoroutine = null;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (cubeCoroutine == null)
            {
                cubeCoroutine = StartCoroutine(CubeCoroutine());
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (cubeCoroutine != null)
            {
                StopCoroutine(cubeCoroutine);
                cubeCoroutine = null;
            }
        }
    }
    private IEnumerator CubeCoroutine()
    {
        while (true)
        {
            Debug.Log("coroutine");
            yield return delay;
            Debug.Log("1초 후");
            yield return delay;
            Debug.Log("2초 후");
        }
    }
}
