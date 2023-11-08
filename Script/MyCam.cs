using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MyCam : MonoBehaviour
{
    Vector2 startPoint;
    Vector2 endPoint;

    Touch fingerOne;
    Touch fingerTwo;

    float currentDistance=0;
    float lastDistance=0;

    public Transform character;
    public Transform cameraPivot;

    private float zoomSpeed = 6.5f;
    private float rotateSpeed = 2.8f;
    private float minFOV = 20.0f;
    private float maxFOV = 135.0f;


    void LateUpdate()
    {
        SetCameraPosition();
        RotateCamera();
        ZoomCamera();
    }
    void SetCameraPosition()
    {
        cameraPivot.position = character.position + (Vector3.up * 1);      
    }
  
    void RotateCamera()
    {
#if UNITY_ANDROID
        transform.LookAt(cameraPivot.position);
        if (Input.touchCount == 1 &&Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            fingerOne = Input.GetTouch(0);
            Vector2 touchDelta = fingerOne.deltaPosition;
            float deltaTime = Time.deltaTime;

            float yRotation = touchDelta.x * rotateSpeed * deltaTime;
            transform.RotateAround(cameraPivot.position, Vector3.up, yRotation);
            transform.LookAt(cameraPivot.position);

    
            float xRotation = -touchDelta.y * rotateSpeed *  deltaTime;
            float angle = Vector3.Angle(cameraPivot.up, transform.forward);
            float lockRotate = Mathf.Abs(angle-180);

            if (lockRotate<5.0f)
                if (xRotation > 0)
                    return;

            transform.RotateAround(cameraPivot.position, transform.right, xRotation);
            transform.LookAt(cameraPivot.position);
        }

#elif UNITY_STANDALONE || UNITY_EDITOR
    transform.LookAt(cameraPivot.position);
    if(Input.GetMouseButton(0))
        {
            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            float deltaTime = Time.deltaTime;

            float yRotation = mouseDelta.x * rotateSpeed * deltaTime;
            transform.RotateAround(cameraPivot.position, Vector3.up, yRotation);
            transform.LookAt(cameraPivot.position);

            float xRotation = -mouseDelta.y * rotateSpeed * deltaTime;
            float angle = Vector3.Angle(cameraPivot.up, transform.forward);
            float lockRotate = Mathf.Abs(angle - 180);

            if (lockRotate < 5.0f)
            {
                if (xRotation > 0)
                {
                    return;
                }
            }

            transform.RotateAround(cameraPivot.position, transform.right, xRotation);
            transform.LookAt(cameraPivot.position);
        }
    }
#endif
    }
    void ZoomCamera()
    {
#if UNITY_ANDROID
        ZoomCheck();
        if (currentDistance ==lastDistance)
        {
            return;
        }
        else if ((currentDistance > lastDistance))
        {
            float newFOV = Camera.main.fieldOfView + zoomSpeed;
            newFOV = Mathf.Clamp(newFOV, minFOV, maxFOV);
            Camera.main.fieldOfView = newFOV;
        }
        else if ((currentDistance < lastDistance))
        {
            float newFOV = Camera.main.fieldOfView - zoomSpeed;
            newFOV = Mathf.Clamp(newFOV, minFOV, maxFOV);
            Camera.main.fieldOfView = newFOV;
        }
#elif UNITY_STANDALONE || UNITY_EDITOR
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(Vector3.forward * scrollInput * zoomSpeed);
#endif
        }
    void ZoomCheck()
    {
        if (Input.touchCount == 2)
        {
            fingerOne = Input.GetTouch(0);
            fingerTwo = Input.GetTouch(1);
           
            if (fingerOne.phase == TouchPhase.Moved || fingerTwo.phase ==TouchPhase.Moved)
            {
                startPoint = fingerOne.position;
                endPoint = fingerTwo.position;

                currentDistance = Vector2.Distance(startPoint, endPoint);

                lastDistance = Vector2.Distance(fingerOne.position+fingerOne.deltaPosition, fingerTwo.position+fingerTwo.deltaPosition);
            }
        }
        else
        {
            currentDistance = 0;
            lastDistance = 0;
        }
    }

}
