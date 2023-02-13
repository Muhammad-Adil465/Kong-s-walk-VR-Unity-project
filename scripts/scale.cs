using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{

    public float defaultHeight = 8.5f;
    public Camera camera;
    public bool change = false;

    public void Resize()
    {
        float headHeight = camera.transform.localPosition.y;
        float scale = defaultHeight / headHeight;
        transform.localScale = Vector3.one * scale;
    }
    public void Kongsize()
    {
        float headHeight = camera.transform.localPosition.y;
        float scale1 = defaultHeight * 3 / headHeight;
        transform.localScale = Vector3.one * scale1;
    }
    void start()
    {

        Resize();

    }
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (change == false)
            {
                Kongsize();

            }

            else
            {
                Resize();
            }
            change = !change;
        }


    }

}
