using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player_Move : MonoBehaviour
{
    private float moveSpeed = 5f;         // 이동 속도    

    Rigidbody2D rb2;
    Score sc = new Score();

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A, D 또는 ←, →방향키를 입력받음
        float vertical = Input.GetAxis("Vertical");     // W, S 또는 ↑, ↓ 방향키를 입력받음


        //        Vector3 dir = new Vector3(horizontal, vertical, 0);
        //        rb2.velocity = dir.normalized * moveSpeed;


        //if (sc.score % 5f == 0f && moveSpeed > 10)
        //    moveSpeed -= 5f;


        Vector2 move = new Vector2(horizontal, vertical);
        Vector2 Position = rb2.position;

        Position = Position + (move * moveSpeed * Time.deltaTime);
        rb2.MovePosition(Position);

    }
}
