using UnityEngine;
using static Define;

public class GameScene : BaseScene
{
    private GameStateMachine _stateMachine;

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = EScene.GameScene;

        _stateMachine = new GameStateMachine();
        _stateMachine.ChangeState(new PlayerTurnState(_stateMachine));

        return true;
    }

    public override void Clear()
    {

    }
}
