﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    public void LButtonDown()
    {
        transform.Translate(-1f, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1f, 0, 0);
    }

    void Update()
    {
        // 왼쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1f, 0, 0);  // 왼쪽으로 1 움직이기
        }
        
        // 오른쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1f, 0, 0);    // 오른쪽으로 1 움직이기
        }
    }
}
