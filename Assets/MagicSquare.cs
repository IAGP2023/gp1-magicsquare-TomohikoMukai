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

        for (int loop = 0; loop < 10; ++loop) //-1が無くなるまでループ
        {
            int unknowns_cnt_sum = 0;
            int unknowns_cnt = 0;
            int unknown_i = 0;
            int unknown_j = 0;
            int sum = 0;

            // 各行の未知数を置き換えるコード
            for (int i = 0; i < 5; ++i)
            {
                unknowns_cnt = 0; //未知数の数
                unknown_j = 0;
                sum = 0;
                for (int j = 0; j < 5; ++j) //横方向に走査
                {
                    if (magic[i, j] < 0) //== -1)//未知数
                    {
                        ++unknowns_cnt;
                        unknown_j = j;
                    }
                    else //未知数以外
                    {
                        sum += magic[i, j];
                    }
                }
                unknowns_cnt_sum += unknowns_cnt;
                if (unknowns_cnt == 1)
                {
                    magic[i, unknown_j] = 65 - sum;
                }
            }
            // 各列の未知数を置き換えるコード
            for (int j = 0; j < 5; ++j)
            {
                unknowns_cnt = 0; //未知数の数
                unknown_i = 0;
                sum = 0;
                for (int i = 0; i < 5; ++i) //横方向に走査
                {
                    if (magic[i, j] < 0) //== -1)//未知数
                    {
                        ++unknowns_cnt;
                        unknown_i = i;
                    }
                    else //未知数以外
                    {
                        sum += magic[i, j];
                    }
                }
                unknowns_cnt_sum += unknowns_cnt;
                if (unknowns_cnt == 1)
                {
                    magic[unknown_i, j] = 65 - sum;
                }
            }

            // 左上から右下へのナナメ走査
            unknowns_cnt = 0;
            unknown_i = 0;
            sum = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (magic[i, i] < 0)
                {
                    ++unknowns_cnt;
                    unknown_i = i;
                }
                else
                {
                    sum += magic[i, i];
                }
            }
            unknowns_cnt_sum += unknowns_cnt;
            if (unknowns_cnt == 1)
            {
                magic[unknown_i, unknown_i] = 65 - sum;
            }

            // 右上から左下へのナナメ走査
            unknowns_cnt = 0;
            unknown_i = 0;
            sum = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (magic[i, 4 - i] < 0)
                {
                    ++unknowns_cnt;
                    unknown_i = i;
                }
                else
                {
                    sum += magic[i, 4 - i];
                }
            }
            unknowns_cnt_sum += unknowns_cnt;
            if (unknowns_cnt == 1)
            {
                magic[unknown_i, 4 - unknown_i] = 65 - sum;
            }

            if (unknowns_cnt_sum == 0) //未知数がなくなったら終了
            {
                Debug.Log(loop);
                break;
            }
        }

        // 魔方陣の内容の出力
        for (int i = 0; i < 5; ++i)
        {
            string line = "";
            for (int j = 0; j < 5; ++j)
            {
                line += magic[i, j].ToString() + " ";
            }
            Debug.Log(line);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
