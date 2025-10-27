using UnityEngine;
using UnityEngine.UI;

public class SeatCustomisationView : UIView
{
    private UIManager _uiManager;

    [SerializeField] Button backButton;

    protected void Awake()
    {
        base.Awake();
        _uiManager = FindFirstObjectByType<UIManager>();
    }

    private void Start()
    {
        backButton.onClick.AddListener(() => OnBackButtonClicked());
    }

    private void OnBackButtonClicked()
    {
        Hide();
        _uiManager.Show<MainMenuView>();
    }
}
