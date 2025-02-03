using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int index;
    
    [SerializeField]private int selectPlayer = 0;

    public void BlockSlected()
    {
        if (selectPlayer != 0)
            return;
        
        //선택 가능한 상태라면 게임매니저에게 인덱스를 보내면서 어쩌구저쩌구
        GameManager.Instance.CallBloackChecker(index);


    }

    public void Checker(int p)
    {
        selectPlayer = p;
    }
}
