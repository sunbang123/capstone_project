using UnityEngine;
using static Define;

public class UI_TitleScene : UI_Scene
{
    enum GameObjects
    {
        Title,
        StartImage,
    }

    enum Texts
    {
        TitleText,
        DisplayText
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));

        GetObject((int)GameObjects.StartImage).BindEvent((evt) =>
        {
            Debug.Log("ChangeScene");
            Managers.Scene.LoadScene(EScene.GameReadyScene);
        });

        GetText((int)GameObjects.StartImage).gameObject.SetActive(false);
        GetText((int)Texts.DisplayText).text = $"";

        StartLoadAssets();

        return true;
    }

    void StartLoadAssets()
    {
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");

            if (count == totalCount)
            {
                Managers.Data.Init();

                GetText((int)GameObjects.StartImage).gameObject.SetActive(true);
                GetText((int)Texts.DisplayText).text = $"Touch To Start";
                // 애니메이션
                UI_DOTween.ApplyFadeMovement(GetText((int)Texts.DisplayText), 1.0f);
            }

        });

        
    }
}
