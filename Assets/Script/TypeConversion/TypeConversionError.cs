using UnityEngine;

// TypeConversionError (���ĺ�ȯ) : 
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long�� ���� l�� �����ϰ� long�� ������ ���� �� �ִ� ����ū ���� ���� �Ѵ�.
        long l = long.MaxValue;
        Debug.Log("l�� ��: " + l);    // l�� ���� �ܼ����� ����϶�


        //[2] int�� ���� i�� �����ϰ� l�� ���� ����
        int i = (int)l;
        Debug.Log("i�� ��:" + i);
    }
}
