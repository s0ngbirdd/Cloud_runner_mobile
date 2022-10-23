using UnityEngine;

public class DeactivateAfterFinish : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.activeSelf && FinishLevel.isFinish)
        {
            gameObject.SetActive(false);
        }
    }
}
