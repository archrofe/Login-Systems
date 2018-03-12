using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LSManager : MonoBehaviour
{
    public bool showSignUp;
    public bool showForgotPassword;

    public GameObject login;
    public GameObject signUp;
    public GameObject forgotPassword;

    public Text createUserText;
    public Text createEmailText;
    public Text createPasswordText;
    public string userName, eMail, passWord;

    public void BackToMenu()
    {
        showSignUp = false;
        showForgotPassword = false;
        userName = "";
        eMail = "";
        passWord = "";
    }

    public void SubmitUser()
    {
        Debug.Log("Sending");
        userName = createUserText.text;
        eMail = createEmailText.text;
        passWord = createPasswordText.text;
        StartCoroutine(CreateAccount(userName, eMail, passWord));
    }

    IEnumerator CreateAccount(string username, string email, string password)
    {
        string createUserURL = "http://localhost/loginsystem/insertuser.php";
        WWWForm user = new WWWForm();
        user.AddField("username_Post", username);
        user.AddField("email_Post", email);
        user.AddField("password_Post", password);
        WWW www = new WWW(createUserURL, user);
        yield return www;
        Debug.Log(www.text);
    }

    public void SignUp()
    {
        ToggleSignUp();
    }

    public void ForgotPassword()
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
    //NOTIFY if create user BackToMenu();
}