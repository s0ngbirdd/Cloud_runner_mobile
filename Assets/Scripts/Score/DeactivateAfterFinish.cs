using UnityEngine;

public class DeactivateAfterFinish : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.activeSelf && FindObjectOfType<FinishLevel>().IsFinish)
        {
            gameObject.SetActive(false);
        }
    }
}
