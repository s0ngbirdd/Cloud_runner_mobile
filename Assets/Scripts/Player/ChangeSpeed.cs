using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public void SpeedChange(float speed)
    {
        ForwardMovement.speed = speed;
    }
}
