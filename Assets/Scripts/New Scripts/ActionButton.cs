using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    Button button;
    public ButtonState state;
    public ActionSO action;
    public UpgradeSO requiredUpgrade;
    public GameObject descriptionWindow;
    // Start is called before the first frame update
    void Awake()
    {
        button = GetComponent<Button>();
    }

    private void Start()
    {
        
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
            if (UpgradeManager.Instance.CheckUpgradeNumber(a) >= a.upgradeLimit)
            {
                state = ButtonState.UpgradeMaxed;
                DisableButton();
                return;
            }

        }
        if (requiredUpgrade != null)
        {
            if (UpgradeManager.Instance.obtainedUpgrades.Contains(requiredUpgrade))
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
        button.interactable = true;
    }

    public void DisableButton()
    {
        button.interactable = false;
    }

    public enum ButtonState
    {
        CanPress, MissingRessources, RequiresUpgrade, UpgradeMaxed
    }
}
