using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        //this is to check if we re inside the bounds of x - axis
        float deltaX = lookAt.position.x - transform.position.x;    
        //if(deltaX > boundX || deltaX < -boundX)
        //{
        //    if(transform.position.x < lookAt.position.x)
        //    {
        //        delta.x = deltaX - boundX;
        //    }
        //    else
        //    {
        //        delta.x = deltaX + boundX;
        //    }
        //}
        float ClampX = Mathf.Clamp(deltaX, -boundX, boundX);
        delta.x = ClampX;
        //this is to check if we re inside the bounds of y - axis
        float deltaY = lookAt.position.y - transform.position.y;
        //if (deltaY > boundY || deltaY < -boundY)
        //{
        //    if (transform.position.y < lookAt.position.y)
        //    {
        //        delta.y = deltaY - boundY;
        //    }
        //    else
        //    {
        //        delta.y = deltaY + boundY;
        //    }
        //}
        float ClampY = Mathf.Clamp(deltaY, -boundY, boundY);
        delta.y = ClampY;
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
