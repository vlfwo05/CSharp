using UnityEngine;


public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    //�ȳ��ϼ��並 3�� ����ϴ� ���α׷�
    void Start()
    {
        //for(int i = 0; i < 3; i++)    �ݺ�ȸ�� : 3
        //for(int i = 1; i < 4; i++)    �ݺ�Ƚ�� : 4 - 1
        //for(int i = 1; i <= 3; i++)   �ݺ�ȸ�� : 3 - 1 +1
        //for(�ʱ��; ���ǽ�; ������)
        /*for(int i = 0; i < 3; i++)
        {
            //�ݺ����๮
            Debug.Log("�ȳ��ϼ���");
        }
        */

        //[1] �ʱ��
        int i = 0;

        while (i < 3)   //[2]���ǽ�
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            

            //������
            i++;
        }

        //int i = 0; -> ���ǽ� �Ǻ�(i : 0) �� -> ��� -> ������ (i : 1) �� -> ��� 
        //������ i : 2 -> ���ǽ� �Ǻ� (i = 2) �� -> ��� -> ������ (i = 3) ���� -> while�� ���� 
    }
}

/*
While �� - �ݺ���
���ǽ��� true�̸� �ݺ�����  �����Ѵ�
���ǽ��� false�̸� while�� �����Ѵ�

while(���ǽ�)
{
    //�ݺ� ���๮
    //���ǽĿ� ���� ���� ������
}

���ǽ� �Ǻ�(��) -> �ݺ��� ���� -> ���ǽ� �Ǻ� (��) -> �ݺ��� ���� -> ���ǽ� �Ǻ�(����) -> While�� ����

*/