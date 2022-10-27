using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    private float moveSpeed = 5.0f;         // �̵� �ӵ�
    private Vector3 moveDirection = Vector3.zero;   // �̵� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   //�¿� �̵�
        float y = Input.GetAxisRaw("Vertical");     //��, �Ʒ� �̵�

        // �̵����� ����
        moveDirection = new Vector3(x, y, 0);

        // ���ο� ��ġ =  ���� ��ġ + (���� * �ӵ�)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
