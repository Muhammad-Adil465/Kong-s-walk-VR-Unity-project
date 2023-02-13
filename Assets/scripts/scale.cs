using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{

    public float defaultHeight = 8f;
    public Camera camera;
   
    
    

    public void HumanSize()
    {
       
        float headHeight = camera.transform.localPosition.y;
        float scale = defaultHeight / headHeight;
        transform.localScale = Vector3.one * scale;
        
    }

    public void Kongsize()
    {
        
        float headHeight = camera.transform.localPosition.y;
        float scale = defaultHeight  / headHeight;
        transform.localScale = Vector3.one * scale * 13;
        
        
    }
    void start()
    {

        HumanSize();

    }
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Kongsize();

        }

        if (Input.GetButtonDown("Fire3"))
        {
            HumanSize();

        }

    }

}
