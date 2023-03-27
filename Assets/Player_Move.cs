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

        //이동방향 설정
        moveDirection = new Vector3(x, y, 0);

        // 새로운 위치 = 현재 위치 + (방향 * 속도)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        //Rigidbody2D 컴포넌트에 있는 속력(velocity)변수 설정
        //rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }
}
