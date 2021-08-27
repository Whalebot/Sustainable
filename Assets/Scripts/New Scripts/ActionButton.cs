using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionButton : MonoBehaviour
{
    Button button;
    public ButtonState state;
    public ActionSO action;
    public UpgradeSO requiredUpgrade;
    public GameObject lockObject;
    public GameObject maxObject;
    public GameObject descriptionWindow;
    public TextMeshProUGUI upgradeLevel;
    // Start is called before the first frame update
    void Awake()
    {
        button = GetComponent<Button>();
    }

    private void Start()
    {
        button.onClick.AddListener(delegate { ExecuteAction(); });
    }

    private void OnEnable()
    {
        GameManager.Instance.updateGameState += CheckRequirements;
    }

    private void OnDisable()
    {
        GameManager.Instance.updateGameState -= CheckRequirements;
    }

    public void CheckRequirements()
    {


        if (action.GetType() == typeof(UpgradeSO))
        {

            UpgradeSO a = (UpgradeSO)action;
            if (upgradeLevel != null)
            {
                upgradeLevel.text = "" + UpgradeManager.Instance.CheckUpgradeNumber(a);
            }
            if (UpgradeManager.Instance.CheckUpgradeNumber(a) >= a.upgradeLimit)
            {
                state = ButtonState.UpgradeMaxed;
                DisableButton();
                return;
            }

        }
        if (requiredUpgrade != null)
        {
            if (!UpgradeManager.Instance.obtainedUpgrades.Contains(requiredUpgrade))
            {
                state = ButtonState.RequiresUpgrade;
                DisableButton();
                return;
            }
        }
        if (GameManager.Instance.CheckRessources(action.cost))
        {
            state = ButtonState.CanPress;
            ActivateButton();
        }
        else
        {
            state = ButtonState.MissingRessources;
            DisableButton();
        }
    }

    public void ExecuteAction()
    {

        if (action.GetType() == typeof(UpgradeSO))
        {
            //UpgradeSO a = (UpgradeSO)action;
            UpgradeManager.Instance.UnlockUpgrade((UpgradeSO)action);
        }
        else
        {
            FoodManager.Instance.ExecuteProduction((ProductionSO)action);
        }
        CheckRequirements();
    }

    public void Selected()
    {
        print("Selected");
    }

    public void Deselected()
    {
        print("Deselected");
    }

    public void ActivateButton()
    {
        if (lockObject != null)
            lockObject.SetActive(false);
        button.interactable = true;
    }

    public void DisableButton()
    {
        if (maxObject != null)
        {
            if (state == ButtonState.UpgradeMaxed) maxObject.SetActive(true);
        }
        if (lockObject != null)
        {
            if (state == ButtonState.RequiresUpgrade)
                lockObject.SetActive(true);
        }
        button.interactable = false;
    }

    public enum ButtonState
    {
        CanPress, MissingRessources, RequiresUpgrade, UpgradeMaxed
    }
}
