using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if(score >= 90)
        {
            Debug.Log("�ݸ޴�");
        }
        else
        {
            if (score >= 70)
            {
                Debug.Log("���޴�");
            }
            else
            {
                Debug.Log("���޴�");
            }
        }
    }
}

/*
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���
70�̻��̸� ���޴� ���, �׿� �������� ��޴� ���
score�� 85��

[output]
()�޴��� �����Ͽ����ϴ�
*/
