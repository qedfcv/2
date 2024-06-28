using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    Animation ani;
    // �ƶ��ٶ�
    private float moveSpeed = 7.0f;
    // ��ת�ٶ�
    private float rotationSpeed = 100.0f;
    // ��ɫ���������
    private CharacterController cc;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        // ��ȡ��ɫ���������
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {

        // ǰ�����ҷ���
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(h, 0, v);
        // ǰ�������ƶ�
        cc.SimpleMove(transform.TransformDirection(direction) * moveSpeed);
        // ��ǰ�ƶ�
        if (Input.GetKeyDown(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        }
        //��Ծ����
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
        // ����ƶ�
        if (Input.GetKeyDown(KeyCode.S))
        {
            //transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.Self);
        }

        // �����ƶ�
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.Self);
        }

        // �����ƶ�
        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self);
        }

        // ������ת���滻GetKey����
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.Self);
        }

        // ������ת���滻GetKey����
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
        }
        //��Ծ����

        UpdateAnim();
    }
    void UpdateAnim()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = new Vector3(x, 0, z);
        anim.SetFloat("Speed", move.magnitude);
    }
}
