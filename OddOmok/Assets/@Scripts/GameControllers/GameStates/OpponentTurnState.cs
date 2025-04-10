using UnityEngine;

public class OpponentTurnState : IGameState
{
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
