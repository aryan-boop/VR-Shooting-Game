using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{

    [SerializeField] private GameObject objectToBeSpwaned;
    [SerializeField] int numberOfItems;
    [SerializeField] Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0; i < numberOfItems; i++)
        {
            Vector3 position = new Vector3(Random.Range(0f,10f), Random.Range(0f, 10f), Random.Range(0f, 10f));
            Instantiate(objectToBeSpwaned, position, Quaternion.identity, parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
