using ExitGames.Client.Photon.StructWrapping;
using Fusion;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UI_GameScene : UI_Scene
{
    private int _boardSize = 13;

    enum GameObjects
    {
        GameSideImage,
        BoardImage,
        OtherStoneImage,
        MyStoneImage,
        RecentWinRate,
    }

    enum Buttons
    {
        LaughButton,
        AngryButton,
        CryButton,
        PlaceButton,
        ItemButton,
    }

    enum Texts
    {
        OtherRecentWinRateText,
        MyRecentWinRateText,
        PlaceText,
        ItemText,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObjects(typeof(GameObjects));
        BindButtons(typeof(Buttons));
        BindTexts(typeof(Texts));

        GetText((int)Texts.PlaceText).text = "착 수";
        GetText((int)Texts.ItemText).text = "아이템";

        var _data = Managers.Data.TestDic[0];
        GetText((int)Texts.OtherRecentWinRateText).text = $"상대 백돌 승률\n{_data.WhiteWins}승{_data.WhiteGamePlayed - _data.WhiteWins}패({_data.WhiteWins * 100 / _data.WhiteGamePlayed}%)";
        GetText((int)Texts.MyRecentWinRateText).text = $"나의 흑돌 승률\n{_data.BlackWins}승{_data.BlackGamePlayed - _data.BlackWins}패({_data.BlackWins * 100 / _data.BlackGamePlayed}%)";

        InitBoardCell();

        return true;
    }

    void InitBoardCell()
    {
        for (int x = 0; x < _boardSize;  x++)
        {
            for (int y = 0; y < _boardSize; y++)
            {
                GameObject go = new GameObject { name = $"Cell({x}, {y})" };
                go.transform.SetParent(GetObject((int)GameObjects.BoardImage).transform, false);
                go.AddComponent<Image>();
                go.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
            }
        }
    }
}
