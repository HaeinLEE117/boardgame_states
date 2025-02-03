using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.Events;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] private int boardSize = 9;
    public Block[] Init()
    {
        Block[] blocks = new Block[boardSize];
        for (int i = 0; i < boardSize; i++)
        {
            Block b = Instantiate(block, transform).GetComponent<Block>();
            b.index = i;
            
            blocks[i]=b;
        }
        return blocks;
    }
}
