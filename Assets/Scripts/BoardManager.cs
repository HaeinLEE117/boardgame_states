using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] Board board;
    Block[] blocks;
    
    void Start()
    {
        blocks = board.Init();

    }
    
    void Update()
    {
        
    }
}
