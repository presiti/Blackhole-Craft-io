using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    private float moveSpeed = 5.0f;         // 이동 속도
    private Vector3 moveDirection = Vector3.zero;   // 이동 방향

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   //좌우 이동
        float y = Input.GetAxisRaw("Vertical");     //위, 아래 이동

        // 이동방향 설정
        moveDirection = new Vector3(x, y, 0);

        // 새로운 위치 =  현재 위치 + (방향 * 속도)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
