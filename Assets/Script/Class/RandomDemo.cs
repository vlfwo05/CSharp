using UnityEngine;

//Random Ŭ���� : �������� ���õ� ������, �޼������ �ִ� Ŭ����
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Random Ŭ������ ��ü ����
        System.Random random = new System.Random();
        
        //������ ����
        Debug.Log(random.Next());
        // 0~4 �� �ϳ��� �� ���ϱ�
        Debug.Log(random.Next(5));
        // 1~9 �� �ϳ��� �� ���ϱ�
        Debug.Log(random.Next(1, 10));
    }
}
