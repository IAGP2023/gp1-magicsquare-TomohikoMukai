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
        magic[1, 0] = 7;
        magic[1, 1] = -1;
        magic[1, 2] = -1;
        magic[1, 3] = 5;
        magic[1, 4] = 19;
        magic[2, 0] = 7;
        magic[2, 1] = -1;
        magic[2, 2] = -1;
        magic[2, 3] = 5;
        magic[2, 4] = 19;
        magic[3, 0] = 7;
        magic[3, 1] = -1;
        magic[3, 2] = -1;
        magic[3, 3] = 5;
        magic[3, 4] = 19;
        magic[4, 0] = 7;
        magic[4, 1] = -1;
        magic[4, 2] = -1;
        magic[4, 3] = 5;
        magic[4, 4] = 19;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
