using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] public UnityEvent OnPetCalled { get; private set; } = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CallPet();
        }
    }
    private void CallPet()
    {
        OnPetCalled?.Invoke();
    }
}
