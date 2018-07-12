using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementRange = 1f;
    public float sideSpeed = 1f;

    /// <summary>
    /// 0 = left
    /// 1 = Middle
    /// 2 = Right
    /// </summary>
    //private int currentSide = 1; 
    Transform player;  // Drag your player here
    Vector2 fp;  // first finger position
    Vector2 lp;  // last finger position
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fp = lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {

                /*if ((fp.x - lp.x) > 80) // left swipe
                {
                    player.Rotate(0, -90, 0);
                }
                else if ((fp.x - lp.x) < -80) // right swipe
                {
                    player.Rotate(0, 90, 0);
                }
                else if ((fp.y - lp.y) < -80) // up swipe
                {
                    // add your jumping code here
                }*/
            }
        }
#if UNITY_EDITOR
        transform.localPosition = new Vector3(Mathf.Clamp((Input.GetAxis("Horizontal") * sideSpeed * Time.timeScale) + transform.localPosition.x, -movementRange, movementRange)
                                         , Mathf.Clamp((Input.GetAxis("Vertical") * sideSpeed * Time.timeScale) + transform.localPosition.y, -movementRange, movementRange)
                                         , transform.localPosition.z);
#endif
#if UNITY_ANDROID
         transform.localPosition = new Vector3(Mathf.Clamp(((fp.x - lp.x)/100 * sideSpeed * Time.timeScale) + transform.localPosition.x, -movementRange, movementRange)
                                         , Mathf.Clamp(((fp.y - lp.y) / 100 * sideSpeed * Time.timeScale) + transform.localPosition.y, -movementRange, movementRange)
                                         , transform.localPosition.z);
#endif
    }
}
