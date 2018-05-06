using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vector3moj {

    public float x;
    public float y;
    public float z;

    public Vector3moj()
    {

    }

    public Vector3moj(float a, float b, float c)
    {
        this.x = a;
        this.y = b;
        this.z = c;
    }

    public Vector3 ToVector3 ()
    {
        Vector3 v = new Vector3();
        v.x = this.x;
        v.y = this.y;
        v.z = this.z;
        return v;
    }
}
