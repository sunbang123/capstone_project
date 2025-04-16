using UnityEngine;

public class EnterVanishingModeState : IGameState
{
    private GameStateMachine _stateMachine;
    private UI_GameScene _uiGameScene;

    public EnterVanishingModeState(GameStateMachine stateMachine, UI_GameScene uiGameScene)
    {
        _stateMachine = stateMachine;
        _uiGameScene = uiGameScene;
    }

    public void Enter()
    {
        Debug.Log("사라지는 모드 진입!");

        if (GameServerManager.GameServer.GetPlayerType() == PlayerCharacter.PlayerType.WhitePlayer)
            _stateMachine.ChangeState(new VanishingPlayerTurnState(_stateMachine, _uiGameScene));
        else
            _stateMachine.ChangeState(new VanishingOpponentTurnState(_stateMachine, _uiGameScene));
    }
    public void Update()
    {

    }
    public void Exit() 
    {
    
    }
}
