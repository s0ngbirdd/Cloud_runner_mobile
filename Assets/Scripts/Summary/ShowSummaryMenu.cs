using UnityEngine;

public class ShowSummaryMenu : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private GameObject _popupMenu;

    public void Update()
    {
        if (!_popupMenu.activeSelf && FindObjectOfType<FinishLevel>().IsFinish)
        {
            _popupMenu.SetActive(true);
        }
    }
}
