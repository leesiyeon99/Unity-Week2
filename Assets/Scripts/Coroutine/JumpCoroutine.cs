using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCoroutine : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float delay;

    Coroutine delayJumpCoroutine;
    WaitForSeconds delayTime;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        delayTime = new WaitForSeconds(delay);
        delayJumpCoroutine = null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (delayJumpCoroutine == null) //������ �������� ��Ȳ���� ��� �������� ���ϵ��� ����
            {
                delayJumpCoroutine = StartCoroutine(DelayJump());
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (delayJumpCoroutine != null)
            {
                StopCoroutine(delayJumpCoroutine);
                delayJumpCoroutine = null;
            }
        }
    }

    IEnumerator DelayJump()
    {
        Debug.Log($"{delay}�� ����");
        yield return delayTime;
        Debug.Log("����");

        rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);

        delayJumpCoroutine = null; //������ �ϰ� �� �� null�� ���� ���� ���°� ������ ���� ������ �����ϵ���
    }
}
