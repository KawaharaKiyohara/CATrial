using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2 startTouchPos;
    Vector2 endTouchPos;

    float flickValue_x;
    float flickValue_y;

    public int HP = 1;   // 現在の体力
    public int NowScore = 0;   // 現在のスコア

    Rigidbody2D player_rb;

    [SerializeField] float jumpPower = 1.0f;

    void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
        NowScore = 0;
    }

    void Update()
    {
        Debug.Log(NowScore); // ログを表示する
        if (HP <= 0)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0)==true)
        {
            startTouchPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if (Input.GetMouseButtonUp(0) == true)
        {
            endTouchPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        FlickDirection();
        GetDirection(); 
    }

    void FlickDirection()
    {
        flickValue_y = endTouchPos.y - startTouchPos.y;
        jumpPower = flickValue_y * 0.03f;
        if (jumpPower <= 0.0f)
        {
            jumpPower = 0.0f;
        }
            if (jumpPower >= 10.0f)
        {
            jumpPower = 10.0f;
        }
        Debug.Log("x スワイプ量は" + flickValue_y);
    }

    void GetDirection()
    {
        if (Input.GetMouseButtonUp(0) == true)
        {
            player_rb.velocity = new Vector2(0, 0);
            player_rb.velocity += new Vector2(0, jumpPower);
        }
    }
}
