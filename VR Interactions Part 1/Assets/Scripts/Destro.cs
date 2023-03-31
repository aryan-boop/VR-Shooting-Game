using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destro : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("DestroCol"))
        {
            Destroy(collision.gameObject);
        }
    }
}
