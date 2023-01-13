using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotationController : MonoBehaviour
{
    private float randomRotation;

    [SerializeField] private float rotationValue;
    void Start()
    {
        GenerateRandomRotationValue();
        setLineRotation();
    }

    private void GenerateRandomRotationValue()
    {
        randomRotation = Random.Range(-rotationValue, rotationValue);
    }

    private void setLineRotation()
    {
        if (IsLineExitedFromTopOfScreen())
        {
            transform.rotation = Quaternion.Euler(0f,0f, -60f);
        }
        else if (IsLineExitedFromBottomOfScreen())
        {
            transform.rotation = Quaternion.Euler(0f,0f, 60f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f,0f, randomRotation);
        }
    }

    private bool IsLineExitedFromTopOfScreen()
    {
        if (transform.position.y >= 6)
        {
            return true;
        }
        return false;
    }
    
    private bool IsLineExitedFromBottomOfScreen()
    {
        if (transform.position.y <= -6)
        {
            return true;
        }
        return false;
    }
}