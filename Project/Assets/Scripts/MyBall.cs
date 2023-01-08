using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // RigidBody에 집중한 파트
    // Start is called before the first frame update
    Rigidbody rigid;                                                                //선언

    void Start()
    {
        rigid = GetComponent<Rigidbody>();                                          // 초기화 : 자신의 <?>타입 컴포넌트를 가져옴
        // 1. 속력 바꾸기
        /*rigid.velocity = new Vector3(2, 4, 3);                                    //velocity : 현재 이동 속도*/
        // 2. 힘을 가하기
        /*rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);                       //AddForce(Vec) : Vec의 방향과 크기로 힘을 줌, ForceMode :*/
                                                                                    //힘을 주는 방식 (가속, 무게 반영), Impulse는 캐릭터 점프에 자주 사용
                                                                                    //무게 Mass에 영향을 받음
                                                                                    //AddForce의 힘 방향으로 계속 속도 velocity가 증가
    }

    private void FixedUpdate()
    {
        // RigidBody 관련 코드는 물리에 해당하므로 FixedUpdate에 작성!! (유니티 권장)
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 
                                  0,
                                  Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        // 3. 회전력
        rigid.AddTorque(Vector3.up);                                                    //AddTorque(Vec) : Vec방향을 축으로 회전력이 생김
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //TriggerStay : 콜라이더가 계속 충돌하고 있을 때 호출
    //매개변수 타입이 Collider인 이유는 물리적인 작용이 아니기 때문이다.
    private void OnTriggerStay(Collider other)
    {
        //Cube라는 이름을 가진 오브젝트와 겹치게 될 경우 실행
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    /* 실제 물리적인 충돌로 발생하는 이벤트
     * void onCollisionEnter(Collision collision) { }
     * void onCollisionStay(Collision collision) { }
     * void onCollisionExit(Collision collision) { }
     
     * 콜라이더 충돌로 발생하는 이벤트
     * void onTriggerEnter(Collider other) { }
     * void onTriggerStay(Collider other) { }
     * void onTriggerExit(Collider other) { } */

    /*Canvas : UI가 그려지는 도화지 역활인 컴포넌트
     스크린 : 게임이 표시되는 화면, 해상도로 크기 결정. 
     Text : 문자열을 표시하는 UI 
     Image : 이미지를 표시하는 UI
     --> 이미지 파일을 적용할 때 이미지 파일의 타입을 Sprite로 설정해야 UI 적용 가능
     --> Preserve Aspect : 비율 고정
     --> Set Native Size : 실제 크기로 맞춰줌
     --> Image Type 4가지 / Simple : 가로 세로 그냥 늘어남, 
        / Sliced : 이미지의 모서리를 늘리거나 잘라서 배치하고 가운데에 채움
        / Tiled : 가로 세로 설정된 값만큼 복사 / Filed : 채움
     UI는 Hierarcy의 순서에 따라 위 아래 결정
     Button
     --> Interactable : 버튼 활성화/비활성화
     --> Navigation : 게임 실행 중 Tab키를 이용한 컴포넌트 이동이 어느방향으로 이루어질 지
     --> OnClick() : 버튼 클릭 시 호출되는 이벤트 함수
     앵커 : Rect Transform에 있는 UI 고정
     */
}
