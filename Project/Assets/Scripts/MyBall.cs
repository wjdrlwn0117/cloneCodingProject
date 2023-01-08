using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // RigidBody�� ������ ��Ʈ
    // Start is called before the first frame update
    Rigidbody rigid;                                                                //����

    void Start()
    {
        rigid = GetComponent<Rigidbody>();                                          // �ʱ�ȭ : �ڽ��� <?>Ÿ�� ������Ʈ�� ������
        // 1. �ӷ� �ٲٱ�
        /*rigid.velocity = new Vector3(2, 4, 3);                                    //velocity : ���� �̵� �ӵ�*/
        // 2. ���� ���ϱ�
        /*rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);                       //AddForce(Vec) : Vec�� ����� ũ��� ���� ��, ForceMode :*/
                                                                                    //���� �ִ� ��� (����, ���� �ݿ�), Impulse�� ĳ���� ������ ���� ���
                                                                                    //���� Mass�� ������ ����
                                                                                    //AddForce�� �� �������� ��� �ӵ� velocity�� ����
    }

    private void FixedUpdate()
    {
        // RigidBody ���� �ڵ�� ������ �ش��ϹǷ� FixedUpdate�� �ۼ�!! (����Ƽ ����)
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 
                                  0,
                                  Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        // 3. ȸ����
        rigid.AddTorque(Vector3.up);                                                    //AddTorque(Vec) : Vec������ ������ ȸ������ ����
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //TriggerStay : �ݶ��̴��� ��� �浹�ϰ� ���� �� ȣ��
    //�Ű����� Ÿ���� Collider�� ������ �������� �ۿ��� �ƴϱ� �����̴�.
    private void OnTriggerStay(Collider other)
    {
        //Cube��� �̸��� ���� ������Ʈ�� ��ġ�� �� ��� ����
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    /* ���� �������� �浹�� �߻��ϴ� �̺�Ʈ
     * void onCollisionEnter(Collision collision) { }
     * void onCollisionStay(Collision collision) { }
     * void onCollisionExit(Collision collision) { }
     
     * �ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ
     * void onTriggerEnter(Collider other) { }
     * void onTriggerStay(Collider other) { }
     * void onTriggerExit(Collider other) { } */

    /*Canvas : UI�� �׷����� ��ȭ�� ��Ȱ�� ������Ʈ
     ��ũ�� : ������ ǥ�õǴ� ȭ��, �ػ󵵷� ũ�� ����. 
     Text : ���ڿ��� ǥ���ϴ� UI 
     Image : �̹����� ǥ���ϴ� UI
     --> �̹��� ������ ������ �� �̹��� ������ Ÿ���� Sprite�� �����ؾ� UI ���� ����
     --> Preserve Aspect : ���� ����
     --> Set Native Size : ���� ũ��� ������
     --> Image Type 4���� / Simple : ���� ���� �׳� �þ, 
        / Sliced : �̹����� �𼭸��� �ø��ų� �߶� ��ġ�ϰ� ����� ä��
        / Tiled : ���� ���� ������ ����ŭ ���� / Filed : ä��
     UI�� Hierarcy�� ������ ���� �� �Ʒ� ����
     Button
     --> Interactable : ��ư Ȱ��ȭ/��Ȱ��ȭ
     --> Navigation : ���� ���� �� TabŰ�� �̿��� ������Ʈ �̵��� ����������� �̷���� ��
     --> OnClick() : ��ư Ŭ�� �� ȣ��Ǵ� �̺�Ʈ �Լ�
     ��Ŀ : Rect Transform�� �ִ� UI ����
     */
}
