using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()                        //�ʱ�ȭ - ����  (���� ������Ʈ ������ ��, ���� ����)
    {

    }
    void OnEnable()                     //Ȱ��ȭ (���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��)
    {

    }
    void Start()                        //�ʱ�ȭ - ������ ����  (������Ʈ ���� ����, ���� ����)
    {

    }
    void FixedUpdate()                  //������ - ����  (������ ���� �ֱ�� CPU�� ���� ���)
    {

    }
    void Update()                       //������ - ����  (���� ���� ������Ʈ, ȯ�濡 ���� ���� �ֱⰡ ������ �� ����)
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime, //��ư�� ���� 
            Input.GetAxisRaw("Vertical") * Time.deltaTime,
            0); ;                         //���� ��
        //Time.deltaTime ����ϴ� ��� : ���� �������� �Ϸ���� �ɸ� �ð�
        //deltaTime���� �������� ������ ũ��, �������� ������ ����
        // 1. Translate : ���Ϳ� ���ϱ�
        // transform.Translate(Vec * Time.deltaTime);
        // 2. Vector �Լ� : �ð� �Ű������� ���ϱ�
        // Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
        transform.Translate(vec);       //Translate : ���� ���� ���� ��ġ�� ���ϴ� �Լ�
                                        //������Ʈ�� ���� transform�� �׻� ������ ����.
    }
    void LateUpdate()                   //������ - ��ó�� (��� ������Ʈ ���� ��) 
    {

    }
    void OnDisable()                    //��Ȱ��ȭ (���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��)
    {

    }
    void OnDestroy()                    //��ü (���� ������Ʈ�� ������ ��)
    {

    }

}
