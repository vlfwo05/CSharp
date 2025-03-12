using UnityEngine;

public class ClassMember
{
    //[1] 정적(static) 매서드
    public static void StaticMethod()
    {
        Debug.Log("[1] 정적(static) 매서드");
    }

    //[2] 인스턴스(Instancce) 매서드
    public void InstanceMethod()
    {
        Debug.Log("'[2] 인스턴스(Instancce) 매서드");
    }


}
