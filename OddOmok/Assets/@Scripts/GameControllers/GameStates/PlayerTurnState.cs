using UnityEngine;

public class PlayerTurnState : IGameState
{
    private GameStateMachine _stateMachine;

    public PlayerTurnState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void IGameState.Update()
    {
        Update();
    }
}
