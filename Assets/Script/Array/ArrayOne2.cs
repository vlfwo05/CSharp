using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� �迭, ����, ��Ҽ�(����) ����, �� �ʱ�ȭ�� ����
        //int[] intArray = new int[3] { 1, 2, 3 };
        //[1-2] 1���� �迭 ����, ��Ҽ�(����) �����ϸ鼭 ũ�� ����, �� �ʱ�ȭ�� ����
        //int[] intArray = new int[] { 1, 2, 3, 4 };
        //[1-3] 1���� �迭 ����, �� �ʱ�ȭ�� ����
        int[] intArray = { 1, 2, 3, 4 };

        //[2] �迭�� ���
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}��° ���� ���� :" + $"{intArray[i]}");
        }

    }
}
