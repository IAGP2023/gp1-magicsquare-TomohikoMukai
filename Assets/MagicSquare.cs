using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[,] magic = new int[5, 5];
        magic[0, 0] = 7;
        magic[0, 1] = -1;
        magic[0, 2] = -1;
        magic[0, 3] = 5;
        magic[0, 4] = 19;
        magic[1, 0] = 3;
        magic[1, 1] = -1;
        magic[1, 2] = 9;
        magic[1, 3] = -1;
        magic[1, 4] = -1;
        magic[2, 0] = 14;
        magic[2, 1] = 22;
        magic[2, 2] = 1;
        magic[2, 3] = 18;
        magic[2, 4] = -1;
        magic[3, 0] = -1;
        magic[3, 1] = 8;
        magic[3, 2] = -1;
        magic[3, 3] = -1;
        magic[3, 4] = -1;
        magic[4, 0] = -1;
        magic[4, 1] = 4;
        magic[4, 2] = 17;
        magic[4, 3] = 6;
        magic[4, 4] = 13;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
