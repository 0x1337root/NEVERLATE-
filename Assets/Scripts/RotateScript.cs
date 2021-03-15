using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private float rotateSpeed = 20f;

    private float touchPos;

    public ScoreManager scoreManager;

    void Update()
    {
        if (scoreManager.canStartable)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    touchPos = touch.deltaPosition.x;

                    transform.Rotate(Vector3.up * rotateSpeed * -touchPos * Time.deltaTime);
                }
            }
        }
    }
}
