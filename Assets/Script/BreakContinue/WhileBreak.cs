using Unity.VisualScripting;
using UnityEngine;

//"1���� 10������ ������ ���� ���ϴ� ���α׷� ����
//���� ���� 22�̻��̵Ǹ� ���̻� ���� �������ʴ´�
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        int i = 0;

        while(i <= n)
        {
            sum += i;
            if (sum >=goal)
            {
                break;
            }

            i++;
        }
    }
}
