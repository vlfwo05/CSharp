using UnityEngine;

//continue���� �ݺ������� continue���� ������ continue�� �Ʒ��� �ִ� ���๮�� �������� �ʰ�
//���� �ݺ����� ���ǽ��� �Ǻ��� ���� �ݺ����� �����Ѵ�
public class Continuefor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //1���� 5���� Ȧ���� ����ϴ� ���α׷�
        for(int i = 1; i <= 5; i++)
        {
            if(i % 2 != 0)  //Ȧ�� �Ǻ���
            {
                Debug.Log(i);
            }
            */
        for (int i = 1; i <= 5; i++)
        {
            if(i % 2 == 0)  //¦�� �Ǻ���
            {
                continue;
            }

            Debug.Log(i);
        }
    }
}
