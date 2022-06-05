using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    

    [SerializeField]
    private int Question_index;


    [SerializeField]
    private Image[] buttons;

    [SerializeField]
    private Color green;


    private GameManager gameManager;

    [SerializeField]
    private string GameManagerNameInString;

    
    private void Start()
    {
        gameManager = GameObject.Find(GameManagerNameInString).GetComponent<GameManager>();
    }

    public void onButtonPress(int index)
    {
        gameManager.user_answers[Question_index] = index;
        for (int i = 0; i < 4; i++)
        {
            if (index == i)
            {
                buttons[i].color = green;

            }
            else
            {
                buttons[i].color = Color.white;

            }
        }
    }
}
