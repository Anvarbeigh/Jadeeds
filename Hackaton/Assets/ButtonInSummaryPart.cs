using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInSummaryPart : MonoBehaviour
{
    [SerializeField]
    private GameObject SummaryText;

    [SerializeField]
    private Transform hide_summaryButton;


    private bool isSummaryHided = false;

    public void onHideSummaryButtonPressed()
    {
        if(isSummaryHided)
        {
            SummaryText.SetActive(true);
            isSummaryHided = false;
            hide_summaryButton.eulerAngles += new Vector3(0, 0, 180);
        }
        else if (isSummaryHided == false)
        {
            isSummaryHided = true;
            hide_summaryButton.eulerAngles += new Vector3(0, 0, 180);
            SummaryText.SetActive(false);
        }

    }

}
