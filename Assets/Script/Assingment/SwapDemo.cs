using UnityEngine;


public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"ó�� i: {i}, j: {j}");

        //�ڸ� �ٲٱ�
        temp = i; //�ӽú���(temp)�� i�� ����
        i = j;  //i ������ j�� ����
        j = temp;   //j ������ �ӽú����� ���� �Ǿ��� i���� ����

        Debug.Log($"���� �� i: {i}, j: {j}");
    }
}

/*
[Q]
+, -, *, / ���� ������� ���� i, j�� ���� ���� �ٲپ ���� �ϼ���
temp��� ������ ���� �̿��غ��Ŀ�

[output]
ó�� i:100, j:200
���� i:200, j:100


*/
