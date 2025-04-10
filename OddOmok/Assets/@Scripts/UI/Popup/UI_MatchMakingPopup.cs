using Fusion;
using UnityEngine;

public class UI_MatchMakingPopup : UI_Popup
{
    enum GameObjects
    {
        MatchingImage,
        MatchingCancelImage,
    }

    enum Texts
    {
        MatchingTimeText,
        MatchingCancelText,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindTexts(typeof(Texts));

        GetText((int)Texts.MatchingCancelText).text = "검색 취소";
        GetObject((int)GameObjects.MatchingCancelImage).SetActive(false);

        GetObject((int)GameObjects.MatchingCancelImage).BindEvent(async (evt) =>
        {
            ClosePopupUI();

            await GameServerManager.GameServer.Runner.Shutdown();

            Debug.Log("매칭 취소");
        });

        Managers.Event.OnWaitingForMatch += ShowMatchingCancelButton;

        return true;
    }

    private float elapsedTime = 0f;
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        GetText((int)Texts.MatchingTimeText).text = $"게임 찾는 중 {minutes}:{seconds:00}";
    }

    private void ShowMatchingCancelButton(PlayerRef player)
    {
        Debug.Log("매칭 취소 버튼 활성화");
        GetObject((int)GameObjects.MatchingCancelImage).SetActive(true);
    }
}
