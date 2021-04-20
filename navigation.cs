using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class navigation : MonoBehaviour
{
    public GameObject panelnavigation;
    public GameObject menulogin;
    public GameObject menuoverview;
    public GameObject menureport;
    public GameObject menustudy;
    public GameObject menusettings;
    public GameObject menuteacheroverview;
    public GameObject menuteachersettings;

    EventSystem system;
    public Selectable firstInput;
    public Button submitButton;

    // Start is called before the first frame update
    void Start()
    {
        gotomenulogin();
        system = EventSystem.current;
        firstInput.Select();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            Selectable previous = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
            if (previous != null)
            {
                previous.Select();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if (next != null)
            {
                next.Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            submitButton.onClick.Invoke();
        }
    }

    public void gotomenulogin()
    {
        panelnavigation.SetActive(false);
        menulogin.SetActive(true);
        menuoverview.SetActive(false);
        menureport.SetActive(false);
        menustudy.SetActive(false);
        menusettings.SetActive(false);
        menuteacheroverview.SetActive(false);
        menuteachersettings.SetActive(false);
    }
    public void gotomenuoverview()
    {
        panelnavigation.SetActive(true);
        menulogin.SetActive(false);
        menuoverview.SetActive(true);
        menureport.SetActive(false);
        menustudy.SetActive(false);
        menusettings.SetActive(false);
        menuteacheroverview.SetActive(false);
        menuteachersettings.SetActive(false);
    }
    public void gotomenureport()
    {
        menulogin.SetActive(false);
        menuoverview.SetActive(false);
        menureport.SetActive(true);
        menustudy.SetActive(false);
        menusettings.SetActive(false);
        menuteacheroverview.SetActive(false);
        menuteachersettings.SetActive(false);
    }
    public void gotomenustudy()
    {
        menulogin.SetActive(false);
        menuoverview.SetActive(false);
        menureport.SetActive(false);
        menustudy.SetActive(true);
        menusettings.SetActive(false);
        menuteacheroverview.SetActive(false);
        menuteachersettings.SetActive(false);
    }
    public void gotomenusettings()
    {
        menulogin.SetActive(false);
        menuoverview.SetActive(false);
        menureport.SetActive(false);
        menustudy.SetActive(false);
        menusettings.SetActive(true);
        menuteacheroverview.SetActive(false);
        menuteachersettings.SetActive(false);
    }
    public void gotomenuteacheroverview()
    {
        menulogin.SetActive(false);
        menuoverview.SetActive(false);
        menureport.SetActive(false);
        menustudy.SetActive(false);
        menusettings.SetActive(false);
        menuteacheroverview.SetActive(true);
        menuteachersettings.SetActive(false);
    }
    public void gotomenuteachersettings()
    {
        menulogin.SetActive(false);
        menuoverview.SetActive(false);
        menureport.SetActive(false);
        menustudy.SetActive(false);
        menusettings.SetActive(false);
        menuteacheroverview.SetActive(false);
        menuteachersettings.SetActive(true);
    }
    public void exitgame()
    {
        Application.Quit();
    }

}
