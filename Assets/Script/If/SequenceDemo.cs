using UnityEngine;

//������ : ������ �Ʒ��� ������� ��ɹ��� ���� 
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� ���� - �ʱ�ȭ
        int kor = 100;      //��������
        int eng = 90;       //��������
        
        int total = 0;      //����
        double avg = 0.0;   //��� ����

        //[2] ������ �� ����
        total = kor + eng;  //���� ���ϱ�
        avg = total / 2.0;  //��� ���ϱ�

        //[3] ���� ���
        Debug.Log($"����: {total}");
        Debug.Log($"����: {avg}");
    }
}

/*
 <���> : ���α׷��� �帧(����)�� ���ϴ� ����
 - ������ : ������ �Ʒ��� ������� ��ɹ��� ���� 
 - ���ǹ�(If - else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� ���� �մϴ�. 
 - �ݺ���

*/
