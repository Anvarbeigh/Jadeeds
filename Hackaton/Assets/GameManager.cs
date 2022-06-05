using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Entry, LR, Login, Register, Menu, Game;

    private Transition transition;

    private GameObject current, previous;



    //////////////////////// BACKENDDDDDDD ////////////////////
    private string q1_1 = "Who you are?";
    private string q1_2 = "";
    private string q1_3 = "";
    private string q1_4 = "";
    private string q1_5 = "";

    private string q1_1_answers = "AAA BBB CCC";


    [SerializeField]
    private Text QuestionItself;
    private Text QuestionIndex;

    private Text var_1, var_2, var_3, var_4;

    private void Start()
    {
        transition = GameObject.FindGameObjectWithTag("Transition").GetComponent<Transition>();
    }


    public void ContinueButton()
    {
        transition.PlayTransition(Entry, Menu);
    }

    public void LoginOnLR()
    {
        previous = LR;
        current = Login;
        transition.PlayTransition(LR, Login);
    }

    public void RegisterOnLR()
    {
        previous = LR;
        current = Register;
        transition.PlayTransition(LR, Register);
    }

    public void Back()
    {
        transition.PlayTransition(current, previous);
    }


    public void GetSubject(int i)
    {
        transition.PlayTransition(Menu, Game);
        current = Game;
        previous = Menu;
        if (i == 0)
        {
            
            print("Entered to Math Quiz");
        }

    }

    public void Close()
    {
        if (current == Game && previous == Menu)
        {
            transition.PlayTransition(current, previous);
        }
        if (previous == Game && current == Summary)
        {
            transition.PlayTransition(current, previous);
            current = Game;
            previous = Menu;
        }
        
    }

    [SerializeField]
    private GameObject Summary;


    [SerializeField]
    private GameObject SummaryText, DavomEtishButton, TestText;

    [SerializeField]
    private Transform hide_summaryButton, TestHideButton;


    private bool isSummaryHided = false, isTestHided = true, isTestLocked = true;

    [SerializeField]
    private GameObject lockIcon;


    public void onHideSummaryButtonPressed()
    {
        if (isSummaryHided)
        {
            SummaryText.SetActive(true);
            DavomEtishButton.SetActive(true);
            isSummaryHided = false;
            hide_summaryButton.eulerAngles += new Vector3(0, 0, 180);
        }
        else if (isSummaryHided == false)
        {
            isSummaryHided = true;
            hide_summaryButton.eulerAngles += new Vector3(0, 0, 180);
            SummaryText.SetActive(false);
            DavomEtishButton.SetActive(false);
        }

    }

    public void onThemeButtonPressed(int index)
    {
        current = Summary;
        previous = Game;
        transition.PlayTransition(previous, current);
    }


    public void onHideTestButtonPressed()
    {
        if(isTestLocked == false)
        {
            if (isTestHided)
            {
                TestText.SetActive(true);
                isTestHided = false;
                TestHideButton.eulerAngles += new Vector3(0, 0, 180);
            }
            else if (isTestHided == false)
            {
                isTestHided = true;
                TestHideButton.eulerAngles += new Vector3(0, 0, 180);
                TestText.SetActive(false);
            }
        }
    }




    public void DavomEtish()
    {
        onHideSummaryButtonPressed();
        isTestLocked = false;
        lockIcon.SetActive(false);
        onHideTestButtonPressed();
    }

}
