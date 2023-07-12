using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggler : MonoBehaviour
{
    // Start is called before the first frame update

    bool isOn = false;
    [SerializeField] GameObject informationPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnToggle()
    {
        if (isOn)
        {
            informationPanel.SetActive(false);
            isOn = false;
        }
        else
        {
            informationPanel.SetActive(true);
            isOn = true;
        }
    }
}
