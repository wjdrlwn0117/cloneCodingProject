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
