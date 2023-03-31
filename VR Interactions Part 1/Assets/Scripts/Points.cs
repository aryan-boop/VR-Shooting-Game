using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEntewr(Collision collision)
    {
        if (collision.transform.name=="Bullet")
        {
            KeepScore.Score += 100;
        }
    }
}
