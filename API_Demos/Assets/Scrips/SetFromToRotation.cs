using UnityEngine;
using System.Collections;

public class SetFromToRotation : MonoBehaviour
{

    public Transform A, B, C;
    private Quaternion q1 = Quaternion.identity;

    void Update()
    {
        q1.SetFromToRotation(A.position, B.position);
        //相当于站在A点 以C的X正轴为眼，朝B的方向看

        C.rotation = q1;

        Debug.DrawLine(Vector3.zero,A.position,Color.red);
        Debug.DrawLine(Vector3.zero, B.position, Color.green);
        Debug.DrawLine(C.position ,C.position+new Vector3(0.0f,1.0f,0.0f), Color.black);
    }
}
