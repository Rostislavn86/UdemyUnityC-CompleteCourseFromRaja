﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public int minZoom2D, maxZoom2D;
    public int zoomSpeed2D;

    public int zoomSpeed3D;
    public int minZoom3D, maxZoom3D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //2D Camera
        if (Camera.main.orthographic)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //ZoomIn
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //ZoomOut
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }
        }
        else
        {
            //3D Camera
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //ZoomIn
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //ZoomOut
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }
        }

        //Restrict a value 2d
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
        //Restrict a value 3d
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);
    }

}
