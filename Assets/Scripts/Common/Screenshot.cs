#define ENABLE_SCREENSHOT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if ENABLE_SCREENSHOT
        if (Input.GetKeyDown("space")) {
            ScreenCapture.CaptureScreenshot("MyScreenshot" + counter);
            counter++;
            Debug.Log("Screenshot captured");
        }
#endif
    }
}
