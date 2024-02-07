using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public UIManager manager;

    //public Button button;
    //public TMP_Text text;
    //public TMP_Sprite sprite;    

    public void ActiveState() 
        {
            this.gameObject.SetActive(true);
        }

        public void DesactivateState() 
        {
            this.gameObject.SetActive(false);
        }
}
