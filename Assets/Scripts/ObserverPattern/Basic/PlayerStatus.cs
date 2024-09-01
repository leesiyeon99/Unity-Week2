using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class PlayerStatus : MonoBehaviour
{
    private int hp;

    public int Hp
    {
        get => hp;
        set
        {
            hp = value;
            statusSubject.Notify();
        }
    }

    private int mp;

    public int Mp
    {
        get => mp;
        set
        {
            mp = value;
            statusSubject.Notify();
        }
    }
    public Subject statusSubject { get; private set; } = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp++;
            mp++;
        }
    }
}
