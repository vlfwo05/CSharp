using UnityEngine;

//���� �޼��� ȣ��, �ν��Ͻ� �ż��� ȣ�� 
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� �޼��� ȣ�� - StaticMethod() ȣ��
        //ȣ�� ���: Ŭ�����̸�.�޼��� �̸�()
        ClassMember.StaticMethod();

        //[2] �ν��Ͻ�(Instance) �޼��� ȣ�� -  InstanceMethod() ȣ��
        //ȣ�� ���: 
        // Ŭ������ ��ü(��ü, Instance) ���� (Ŭ������ ���� ����)
        //new Ű���带 �̿��Ͽ� ���ο� ��ä ����
        //(Ŭ�����̸�) ��ü�̸� = new Ŭ�����̸�();
        //(��ü�̸�).�ż��� �̸�

        ClassMember.StaticMethod();

    }
}
