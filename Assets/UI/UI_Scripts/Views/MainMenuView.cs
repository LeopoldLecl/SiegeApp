using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : UIView
{
    private UIManager _uiManager;

    [SerializeField] private Button seatCustomisationButton;
    [SerializeField] private Button seatStructureButton;
    [SerializeField] private Button seatCutButton;
    [SerializeField] private Button seatExplodedButton;

    protected void Awake()
    {
        base.Awake();
        _uiManager = FindFirstObjectByType<UIManager>();
    }

    private void Start()
    {
        seatCustomisationButton.onClick.AddListener(() => OnSeatCustomisationButtonClicked());
        seatStructureButton.onClick.AddListener(() => OnSeatStructureButtonClicked());
        seatCutButton.onClick.AddListener(() => OnSeatStructureButtonClicked());
        seatExplodedButton.onClick.AddListener(() => OnSeatExplodedButtonClicked());
    }


    private void OnSeatCustomisationButtonClicked()
    {
        Hide();
        _uiManager.Show<SeatCustomisationView>();
    }

    private void OnSeatStructureButtonClicked()
    {
        Hide();
        _uiManager.Show<SeatStructureView>();
    }

    private void OnSeatCutButtonClicked()
    {
        Hide();
        _uiManager.Show<SeatCutView>();
    }

    private void OnSeatExplodedButtonClicked()
    {
        Hide();
        _uiManager.Show<SeatExplodedView>();
    }



    }
