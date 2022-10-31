using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player_Move : MonoBehaviour
{
    private static float moveSpeed = 20.0f;         // 이동 속도    

    Rigidbody2D rb2;
    Score sc = new Score();

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(sc.score % 5f == 0f && moveSpeed > 10)
        {
            moveSpeed -= 5f;
        }

        Vector2 position = rb2.position;
        position.x = position.x + moveSpeed * horizontal * Time.deltaTime;
        position.y = position.y + moveSpeed * vertical * Time.deltaTime;

        rb2.MovePosition(position);
    }
}
