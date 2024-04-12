using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabfloat : MonoBehaviour
{
    // �̤j���O�M����O
    public float m_Thrust ;
    public float maxTorque;



    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ApplyRandomForce();
        ApplyRandomTorque();

    }

     void Update()
    {
        //ApplyRandomForce();
        if(this.gameObject.transform.position.y <= 0)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,0, this.gameObject.transform.position.z);
        }
    }

    void ApplyRandomForce()
    {
        rb.AddForce(transform.up * m_Thrust);
    }

    void ApplyRandomTorque()
    {
        Vector3 torque = Random.insideUnitSphere * maxTorque;
        rb.AddTorque(torque, ForceMode.Impulse);
    }

}
