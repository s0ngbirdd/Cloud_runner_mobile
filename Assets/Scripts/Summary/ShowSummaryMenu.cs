using UnityEngine;

public class ShowSummaryMenu : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private GameObject _popupMenu;

    public void Update()
    {
        if (!_popupMenu.activeSelf && FinishLevel.isFinish)
        {
            _popupMenu.SetActive(true);
        }
    }
}
