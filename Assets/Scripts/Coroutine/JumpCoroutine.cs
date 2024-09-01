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
            if (delayJumpCoroutine == null) //점프가 진행중인 상황에서 계속 점프하지 못하도록 구현
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
        Debug.Log($"{delay}후 점프");
        yield return delayTime;
        Debug.Log("점프");

        rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);

        delayJumpCoroutine = null; //점프를 하고 난 후 null로 만들어서 점프 상태가 끝나야 다음 점프가 가능하도록
    }
}
