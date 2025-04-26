using UnityEngine;

public class TurningSprite : MonoBehaviour
{
    [SerializeField] bool freezeXZAxis = true;

    //public Camera playerCam;
    void Update()
    {
        if (freezeXZAxis)
        {
            //x and z axes are not affected
            //affecting the y axis using the information from the player camera 
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
