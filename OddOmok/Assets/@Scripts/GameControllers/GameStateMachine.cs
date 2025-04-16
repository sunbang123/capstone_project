using UnityEngine;

public interface IGameState
{
    void Enter();
    void Update();
    void Exit();
}
public class GameStateMachine
{
    public IGameState _currentState { get; private set; }
    public IGameState _previousState { get; private set; }

    public void ChangeState(IGameState newState)
    {
        _currentState?.Exit();
        _previousState = (_currentState != null) ? _currentState : newState;
        _currentState = newState;
        _currentState.Enter();
    }

    public void Update()
    {
        _currentState?.Update();
    }
}
