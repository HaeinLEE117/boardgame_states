using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : Singleton<BoardManager>
{
    [SerializeField] Board board;
    Block[] blocks;
    
    void Start()
    {
        blocks = board.Init();

    }

    public bool BlockCheck(int _index, int _player)
    {
        blocks[_index].Checker(_player);
        
        //Game Over 여부를 판단해서 돌려주자.
        return false;
    }
    
    //UI업데이트 하는 함수 만들어서 호출하기
}
