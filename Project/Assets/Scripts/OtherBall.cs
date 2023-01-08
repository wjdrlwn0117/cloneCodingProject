using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    // Start is called before the first frame update
    //������Ʈ�� ���� ������ MeshRenderer�� ���ؼ�
    MeshRenderer mesh;
    Material mat;


    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
        
    }
    
    //Collision : �浹 ���� Ŭ����
    //CollisionEnter : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        //Color : �⺻ ���� Ŭ����, Color32 : 255 ���� Ŭ����
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
        // �浹�� �Ͼ�� ���ӿ�����Ʈ�� �̸��� My Ball�� ��� ���� ���������� ����
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    //CollisionExit : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
        // �浹���� �����  ���ӿ�����Ʈ�� �̸��� My Ball�� ��� ���� ���������� ����
    }
}
