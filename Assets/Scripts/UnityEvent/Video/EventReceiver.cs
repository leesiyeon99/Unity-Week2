using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReceiver : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] EventTester tester;

    private void OnEnable()
    {
        tester.OnScream.AddListener(Jump);
    }

    private void OnDisable()
    {
        tester.OnScream.RemoveListener(Jump);
    }


    public void Jump()
    {
        rigid.AddForce(Vector3.up * 8f, ForceMode.Impulse);
    }
}
