using UnityEngine;

//[1] �������� �����ϴ� ������ ����
// ������ ���� ������� 0���� �����ؼ� 1�� �����Ѵ�
enum Animale
{
    Horse,  //0
    Sheep = 5,  //1
    Monkey, //2
}

public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey); //  => 6
    }
}
