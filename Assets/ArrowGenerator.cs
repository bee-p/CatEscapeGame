using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span) // 1초(span 값 기준)마다 생성하도록
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);

            go.GetComponent<ArrowController>().speed = Random.Range(0.01f, 0.5f);    // 속도 랜덤 부여
        }
    }
}
