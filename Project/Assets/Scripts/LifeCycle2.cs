using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    void Update()
    {
        //Input = ���� �� �Է��� �����ϴ� Ŭ����
        if (Input.anyKeyDown)                                       //�ƹ� �Է��� ���ʷ� ���� �� true
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�. ");

        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");     //�ƹ� �Է��� ������ true

        //Ű������ �Է��� ��������, ������ ���� ��, ���� ���� ������ �Է¹���
        if (Input.GetKeyDown(KeyCode.Return))                       //���͸� ������ ��
            Debug.Log("�������� �����Ͽ����ϴ�. ");

        if (Input.GetKey(KeyCode.LeftArrow))                        //���� ����Ű�� ������ ���� ��
            Debug.Log("�������� �̵� �� ");

        if (Input.GetKeyUp(KeyCode.RightArrow))                     //������ ����Ű�� ������ ���� ��
            Debug.Log("������ �̵��� ���߾����ϴ�. ");

        //���콺���� ������ ��, ������ ���� ��, ���� ���� ������ �Է¹��� GetMouseButtone�� �Ű����� 0�� 1�� ���� ����, ������ ��ư�� �ǹ�
        if (Input.GetMouseButtonDown(0))                            //���콺�� ���� ��
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))                                //���콺�� ������ ���� ��
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))                              //���콺�� ���� ��
            Debug.Log("���� �̻��� �߻�!! ");

        //Edit/Input Manager�� �ִ� Jump��ư�� Ȱ���� ���� ������ ��, ������ ���� ��, ���� ���� ������ ����
        if (Input.GetButtonDown("SuperJump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��... ");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!! ");

        if (Input.GetButton("Horizontal"))
            Debug.Log("Ⱦ �̵� ��...." 
                + Input.GetAxisRaw("Horizontal"));
               //+Input.GetAxis("Horizontal")); �� ���ӵ���ŭ�� �̵�, Raw�� ������ �� ����ŭ �ѹ��� �̵�

        if (Input.GetButton("Vertical"))
            Debug.Log("�� �̵� ��...." 
                + Input.GetAxisRaw("Vertical"));

    }
}
