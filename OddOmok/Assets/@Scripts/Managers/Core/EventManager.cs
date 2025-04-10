using Fusion;
using System;
using UnityEngine;

public class EventManager
{
    public event Action<PlayerRef> OnWaitingForMatch;

    public void WaitingForMatch(PlayerRef player)
    {
        OnWaitingForMatch?.Invoke(player);
    }
}
