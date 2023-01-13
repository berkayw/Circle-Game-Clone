using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    [SerializeField] private float endXValue;
    

    // Update is called once per frame
    void Update()
    {
        CheckLinePositionX();
    }

    private void CheckLinePositionX()
    {
        if (transform.position.x <= endXValue)
        {
            Destroy(gameObject);
        }
    }
}
