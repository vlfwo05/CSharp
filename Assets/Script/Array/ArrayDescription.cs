using Mono.Cecil;
using UnityEngine;

// Array(�迭) : ���α׷����� ����ϴ� �����͸� ������ ���� �׸�
// Array(�迭) : �ϳ��� �̸����� ���� ������ ������ ������ ������ ���� �׸�
// ���� : ������ Ÿ��[] ������(�̸�); 
// ũ������ : ������(�̸�) = new ������Ÿ��[ũ��]
public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;


        // [1]�迭 ����
        int[] numbers;

        // [2] �迭�� ��Ҽ� ���� - �׸� ���� ���� - ũ��
        numbers = new int[n];  // 0 ~ n-1 

        //[3] �迭�� ����, ���� - �ʱ�ȭ
        numbers[0] = 3840;
        numbers[1] = 2160;

        // [4] �迭�� ���
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);
    }
}
