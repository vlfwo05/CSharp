using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedInteger
        sbyte iSbyte = 127; //8��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767; //16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32 = 2147483647; //32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 = 9223372036845775807; //64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("sbyre: " + iSbyte);
        Debug.Log("short: " + iInt16);
        Debug.Log("int: " + iInt32);
        Debug.Log("long: " + iInt64);


        //UnSignedInteger
        byte ibyte = 255; //8��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ushort iUInt16 = 65535; //16��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        uint iUInt32 = 4294967295; //32��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ulong iUint64 = 18446744073709551615; //64��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("byte: " + ibyte);
        Debug.Log("ushort: " + iUInt16);
        Debug.Log("intuint: " + iUInt32);
        Debug.Log("ulong: " + iUint64);
    }
}
/*
1Bit 0,1

1Byte : 8Bit

8Bit
(+, -)
sbyte : -128 ~ 127

(+)
byte : 0 ~ 255

*/

/*
SignedInteger (+, -) ��ȣ�� �ִ� ������ ������ ����(Ÿ��)

UnSignedInteger (+, -) ��ȣ�� ���� ������ ������ ����(Ÿ��)
*/



