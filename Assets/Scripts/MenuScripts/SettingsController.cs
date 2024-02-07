using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour
{
    public UIManager uiManager;

    public void ActiveState()
    {
        this.gameObject.SetActive(true);
    }

    public void DesactivateState()
    {
        this.gameObject.SetActive(false);
    }
}
