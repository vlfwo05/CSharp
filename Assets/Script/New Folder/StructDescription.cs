using UnityEngine;

//struct(����ü) : �ϳ��� �̸����� ���� �ٸ� ������ �����͵�, �Ǵ� �Լ����� ��� �����ϴ� �׸�
//[1] ����ü ����, ���� : �ΰ��� ������ �����ϴ� ����ü �����
/*truct Point
{
    public int x;   //public Ű���带 �����ϸ� �ܺο��� int x ������ ��� �����ϵ��� ���� 
    public int y;
}*/

public class StructDescription : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //[2] ����ü ������ ���� ���� : point ����ü ������ ����
        Point p;


        //[3] Point����ü�� x, y ������ ���� ����(����, �Ҵ�) �ʱ�ȭ
        p.x = 100;
        p.y = 100;

        //[4] ���
        Debug.Log($"x: {p.x}, Y: {p.y}");
    }
    struct Point
    {
    public int x;   //public Ű���带 �����ϸ� �ܺο��� int x ������ ��� �����ϵ��� ���� 
    public int y;
}

}

/*
Variable(����) : �����͸� �����ϴ� �׸�
Array(�迭) : �ϳ��� �̸����� ���� ������ �����͸� ������ ��� �׸�, ����, ������ Ȯ��

struct(����ü) : �ϳ��� �̸����� ���� �ٸ� ������ �����͵�, �Ǵ� �Լ����� ��� �����ϴ� �׸� (������ ����)
 : ����� ���� ������ ����

//����ü ����
struct (����ü �̸�)
{
    //���δٸ� ������ �����͵�
    // �Լ���
{

*/
