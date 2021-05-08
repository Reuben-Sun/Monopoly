using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    const int playerNum = 4;
    public GameObject[] player;
    public Text diceText;
    public Text playerNowText;
    int playerNow = 0;
    float[,] mapPosition = new float[,]{
        {9f, -4f },     //起点

        {7.2f, -4.4f },     //11
        {5.8f, -4.4f },
        {4.4f, -4.4f },
        {2.9f, -4.4f },
        {1.5f, -4.4f },
        {0.0f, -4.4f },
        {-1.4f, -4.4f },
        {-2.8f, -4.4f },
        {-4.4f, -4.4f },
        {-5.8f, -4.4f },
        {-7.2f, -4.4f },

        {-9f, -4f },    //蒙德

        {-9.3f, -2.1f },    //4
        {-9.3f, -0.7f },
        {-9.3f, 0.7f },
        {-9.3f, 2.1f },

        {-9f, 4f },     //雪山

        {-7.2f, 4.4f },     //11
        {-5.8f, 4.4f },
        {-4.4f, 4.4f },
        {-2.9f, 4.4f },
        {-1.5f, 4.4f },
        {0.0f, 4.4f },
        {1.4f, 4.4f },
        {2.8f, 4.4f },
        {4.4f, 4.4f },
        {5.8f, 4.4f },
        {7.2f, 4.4f },

        {9f, 4f },       //璃月

        {9.3f, 2.1f },      //4
        {9.3f, 0.7f },
        {9.3f, -0.7f },
        {9.3f, -2.1f },
    };
    string[] playerName = { "小黑", "大哭", "害羞", "滑稽"};

    int[] pos = { 0, 0, 0, 0 };
    // Start is called before the first frame update
    void Start()
    { 
        
        for(int i = 0; i < playerNum; i++)      //初始化位置
        {
            pos[i] = 0;
            this.player[i].transform.localPosition = new Vector3(mapPosition[pos[i], 0], mapPosition[pos[i], 1], 10);
        }
        playerNow = 0;      //零号玩家优先
        diceText.text = null;   //骰子点数暂不显示
        playerNowText.text = playerName[playerNow];     //显示下一步是谁的回合
    }
    public void moveForward()
    {
        int moveSpeed = Random.Range(1, 7);     //获得骰子点数
        diceText.text = moveSpeed.ToString();
        pos[playerNow] += moveSpeed;
        pos[playerNow] %= 34;
        //移动
        this.player[playerNow].transform.localPosition = new Vector3(mapPosition[pos[playerNow], 0], mapPosition[pos[playerNow], 1], 10);
        playerNow++;
        playerNow %= playerNum;
        playerNowText.text = playerName[playerNow];     //显示下一步是谁的回合
       
    }
    //public float timer = 2.0f;
    // Update is called once per frame
    void Update()
    {
        //timer -= Time.deltaTime;
        //if (timer <= 0)
        //{
        //    pos++;
        //    pos %= 4;
        //    this.gameObject.transform.localPosition = new Vector3(mapPosition[pos, 0], mapPosition[pos, 1], 10);
        //    timer = 2.0f;
        //}

    }
}
