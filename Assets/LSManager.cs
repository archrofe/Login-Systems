using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSManager : MonoBehaviour
{
    public bool showSignUp;
    public bool showForgotPassword;

    public GameObject login;
    public GameObject signUp;
    public GameObject forgotPassword;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowSignUp()
    {
        ToggleSignUp();
    }

    public void ShowForgotPassword()
    {
        ToggleForgotPassword();
    }

    public bool ToggleSignUp()
    {
        if (showSignUp)
        {
            showSignUp = false;
            login.SetActive(true);
            signUp.SetActive(false);
            return false;
        }
        else
        {
            showSignUp = true;
            login.SetActive(false);
            signUp.SetActive(true);
            return true;
        }
    }

    public bool ToggleForgotPassword()
    {
        if (showForgotPassword)
        {
            showForgotPassword = false;
            login.SetActive(true);
            forgotPassword.SetActive(false);
            return false;
        }
        else
        {
            showForgotPassword = true;
            login.SetActive(false);
            forgotPassword.SetActive(true);
            return true;
        }
    }
}