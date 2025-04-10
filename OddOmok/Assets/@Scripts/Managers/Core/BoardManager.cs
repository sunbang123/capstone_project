using Fusion;
using UnityEngine;

public class BoardManager : NetworkBehaviour
{
    public enum StoneState
    {
        Empty,
        Black,
        White,
    }

    [Networked]
    public NetworkArray<StoneState> OmokBoard { get; }

    private void Awake()
    {
        
    }

    public override void FixedUpdateNetwork()
    {

    }
}
