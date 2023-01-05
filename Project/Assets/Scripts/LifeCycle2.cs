using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    void Update()
    {
        //Input = 게임 내 입력을 관리하는 클래스
        if (Input.anyKeyDown)                                       //아무 입력을 최초로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다. ");

        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");     //아무 입력을 받으면 true

        //키보드의 입력을 눌렀을때, 누르고 있을 때, 땠을 때로 나누어 입력받음
        if (Input.GetKeyDown(KeyCode.Return))                       //엔터를 눌렀을 때
            Debug.Log("아이템을 구입하였습니다. ");

        if (Input.GetKey(KeyCode.LeftArrow))                        //왼쪽 방향키를 누르고 있을 때
            Debug.Log("왼쪽으로 이동 중 ");

        if (Input.GetKeyUp(KeyCode.RightArrow))                     //오른쪽 방향키를 눌렀다 땠을 때
            Debug.Log("오른쪽 이동을 멈추었습니다. ");

        //마우스또한 눌렀을 때, 누르고 있을 때, 땠을 때로 나누어 입력받음 GetMouseButtone의 매개변수 0과 1은 각각 왼쪽, 오른쪽 버튼을 의미
        if (Input.GetMouseButtonDown(0))                            //마우스를 누를 때
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))                                //마우스를 누르고 있을 때
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))                              //마우스를 땠을 때
            Debug.Log("슈퍼 미사일 발사!! ");

        //Edit/Input Manager에 있는 Jump버튼을 활용한 로직 눌렀을 때, 누르고 있을 때, 땠을 때로 나누어 받음
        if (Input.GetButtonDown("SuperJump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중... ");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!! ");

        if (Input.GetButton("Horizontal"))
            Debug.Log("횡 이동 중...." 
                + Input.GetAxisRaw("Horizontal"));
               //+Input.GetAxis("Horizontal")); 는 가속도만큼씩 이동, Raw가 붙으면 끝 값만큼 한번에 이동

        if (Input.GetButton("Vertical"))
            Debug.Log("종 이동 중...." 
                + Input.GetAxisRaw("Vertical"));

    }
}
