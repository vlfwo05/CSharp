using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run();  //���� Ŭ������ �޼��� ȣ��
        ClassDescription.Run(); //Ŭ���� ������ �޼��� ȣ�� : Ŭ�����̸�.�޼���() ȣ��

    }

    // ClassDescription ��� Ŭ������ Run (����)�޼���(�Լ�)
    static void Run()
    {
        Debug.Log(" ClassDescription ��� Ŭ������ Run() �޼���");
    }

}

/*
class(Ŭ����) - C# �⺻�� �Ǵ� ����
: �ϳ��� �̸����� ���� �ٸ� (������) �����͵�� �Լ����� ��� �����ϴ� �׸�(����)
: ....
: ����� ���� ������ ����

public class (Ŭ���� �̸�)
{

}

*/
