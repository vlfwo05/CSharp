using UnityEngine;

// �������� �����ϴ� ������ ����

enum Animal
{
    Nouse,
    Cow,
    Tiger,
}


public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ������ ����(Animal) �����ϰ� �ʱ�ȭ
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        //[3] ��� - ���ǹ����� ���ǽ�
        if(animal == Animal.Tiger)
        {
            Debug.Log("ȣ����");
        }    

    }
}
