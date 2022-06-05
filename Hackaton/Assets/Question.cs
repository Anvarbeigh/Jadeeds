using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    private int[] answers = { 1 };

    [SerializeField]
    private int Question_index;


    [SerializeField]
    private Image[] buttons;

    [SerializeField]
    private Color green;

    public void onButtonPress(int index)
    {
        for(int i = 0; i < 4; i++)
        {
            if(index == i)
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
