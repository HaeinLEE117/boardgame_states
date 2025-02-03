using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    int currentPlayer = 1;

    public void CallBloackChecker(int index)
    {
        BoardManager.Instance.BlockCheck(index, currentPlayer);
    }
}
