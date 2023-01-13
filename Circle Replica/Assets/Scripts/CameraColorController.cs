using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;


    [SerializeField] private Color[] colors;

    private int colorIndex;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;

    // Update is called once per frame
    void Update()
    {
        ChangeSmoothCameraColor();
        SetColorChangeTime();
    }

    private void ChangeSmoothCameraColor()
    {
        mainCamera.backgroundColor =
            Color.Lerp(mainCamera.backgroundColor, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            IncreaseColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void IncreaseColorIndexValue()
    {
        colorIndex++;
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void OnDestroy() //Restart color
    {
        mainCamera.backgroundColor = colors[1];
    }
}