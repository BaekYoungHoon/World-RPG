using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move: MonoBehaviour
{
    private float moveSpeed = 10.0f;
    private Rigidbody2D rigid2D;
    private Vector3 moveDirection = Vector3.zero;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //�̵����� ����
        moveDirection = new Vector3(x, y, 0);

        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        //Rigidbody2D ������Ʈ�� �ִ� �ӷ�(velocity)���� ����
        //rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }
}
