using UnityEngine;

//[1] ����ü ����, ����: ���� �����͸� �����ϴ� ����ü
struct UesrInfo
{
    public string name; //�� �̸�
    public int age;     //�� ����
    //....

}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ����
        UesrInfo info;
        //[2] �ֱ�ȭ
        info.name = "ȫ�浿";
        info.age = 20;
        PrintUserInfo(info.name, info.age);

        //[1] ����ü�� �迭 ���� ����, �迭�� ��Ҽ�(ũ��) ����
        UesrInfo[] userinfos = new UesrInfo[2];

        //[2] ����ü �迭�� �ʱ�ȭ
        userinfos[0].name = "��λ�";
        userinfos[0].age = 22;
        userinfos[1].name = "�Ӳ���";
        userinfos[1].age = 33;

        //[3] ����ü �迭 ���
        for(int i = 0; i < userinfos.Length; i++)
        {
            PrintUserInfo(userinfos[i].name, userinfos[1].age);
        }

    }

    //���� ����� ��� �ϴ� �Լ�
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴� {age} �Դϴ�");
    }

    /*void PrintUserInfo(UserInfo userINfo)
    {
          Debug.Log($"{userInfo.name}���� ���̴� {userInfo.age}dlqslek");
    }
*/}

