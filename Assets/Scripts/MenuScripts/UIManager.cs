using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //el UIManager se usa para controlar los estados de las UI
    //y para eso se llaman los controladores de los paneles
    public SettingsController settingsController;
    public MainController mainController;

    //Este start se centra en inicializar el MainController
    public void Start()
    {
        MainState();
    }

    //Mediante este metodo se inicializa el mainController y se desactiva los demas
    public void MainState()
    {
        settingsController.DesactivateState();
        mainController.ActiveState();
    }
    public void SettingsState()
    {        
        mainController.DesactivateState();
        settingsController.ActiveState();
    }
}
