using Unity.VisualScripting;
using UnityEngine;
using static Define;

public class GameReadyScene : BaseScene
{
    UI_GameReadyScene _gameReadySceneUI;

    public override bool Init()
    {

        if (base.Init() == false)
            return false;

        SceneType = Define.EScene.GameReadyScene;

        //_gameReadySceneUI

        return true;
    }
}
