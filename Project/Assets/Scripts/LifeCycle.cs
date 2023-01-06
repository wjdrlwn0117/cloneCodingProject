using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()                        //초기화 - 최초  (게임 오브젝트 생성할 때, 최초 실행)
    {

    }
    void OnEnable()                     //활성화 (게임 오브젝트가 활성화 되었을 때)
    {

    }
    void Start()                        //초기화 - 프레임 시작  (업데이트 시작 직전, 최초 실행)
    {

    }
    void FixedUpdate()                  //프레임 - 물리  (고정된 실행 주기로 CPU를 많이 사용)
    {

    }
    void Update()                       //프레임 - 로직  (게임 로직 업데이트, 환경에 따라 실행 주기가 떨어질 수 있음)
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime, //버튼을 통해 
            Input.GetAxisRaw("Vertical") * Time.deltaTime,
            0); ;                         //벡터 값
        //Time.deltaTime 사용하는 방법 : 이전 프레임이 완료까지 걸린 시간
        //deltaTime값은 프레임이 적으면 크고, 프레임이 많으면 작음
        // 1. Translate : 벡터에 곱하기
        // transform.Translate(Vec * Time.deltaTime);
        // 2. Vector 함수 : 시간 매개변수에 곱하기
        // Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
        transform.Translate(vec);       //Translate : 벡터 값을 현재 위치에 더하는 함수
                                        //오브젝트는 변수 transform을 항상 가지고 있음.
    }
    void LateUpdate()                   //프레임 - 후처리 (모든 업데이트 끝난 후) 
    {

    }
    void OnDisable()                    //비활성화 (게임 오브젝트가 비활성화 되었을 때)
    {

    }
    void OnDestroy()                    //해체 (게임 오브젝트가 삭제될 때)
    {

    }

}
