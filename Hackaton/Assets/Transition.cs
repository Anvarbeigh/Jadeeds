using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    private Animator anim;
    private bool isFirstTimeUsing = true;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayTransition(GameObject a, GameObject b)
    {
        StartCoroutine(PlayAnimation(a, b));
    }

    IEnumerator PlayAnimation(GameObject a, GameObject b)
    {
        if(isFirstTimeUsing == true)
        {
            anim.enabled = true;
            isFirstTimeUsing = false;
        }
        else
        {
            anim.Rebind();
        }
        yield return new WaitForSeconds(0.5f);
        a.SetActive(false);
        b.SetActive(true);
    }




}
