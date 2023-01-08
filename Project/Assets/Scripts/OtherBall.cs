using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    // Start is called before the first frame update
    //오브젝트의 재질 접근은 MeshRenderer를 통해서
    MeshRenderer mesh;
    Material mat;


    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
        
    }
    
    //Collision : 충돌 정보 클래스
    //CollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
    private void OnCollisionEnter(Collision collision)
    {
        //Color : 기본 색상 클래스, Color32 : 255 색상 클래스
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
        // 충돌이 일어나는 게임오브젝트의 이름이 My Ball일 경우 색이 검정색으로 변함
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    //CollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
        // 충돌에서 벗어나는  게임오브젝트의 이름이 My Ball일 경우 색이 검정색으로 변함
    }
}
