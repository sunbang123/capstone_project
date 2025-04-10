using Fusion;
using UnityEngine;

public class PlayerCharacter : NetworkBehaviour
{
    [SerializeField]
    private PlayerType _localPlayerType;

    public enum PlayerType
    {
        None,
        Black,
        White,
    }

    private void Awake()
    {
        
    }
}
