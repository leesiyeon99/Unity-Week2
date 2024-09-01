using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class PlayerStatusUI : MonoBehaviour, IObserver
{
    [SerializeField] private PlayerStatus player;
    private void Start()
    {
        Init();
    }
    private void Init()
    {
        player.statusSubject.Subscribe(this);
    }
    public void OnNotify()
    {
        PrintStatus();
    }

    private void PrintStatus()
    {
        Debug.Log($"HP: {player.Hp} \nMP: {player.Mp}");
    }
}
