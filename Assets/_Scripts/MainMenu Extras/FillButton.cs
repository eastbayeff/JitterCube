using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillButton : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(Fill());
    }

    IEnumerator Fill()
    {
        Image img = GetComponent<Image>();
        img.fillAmount = 0;

        while (img.fillAmount < 1)
        {
            img.fillAmount += 0.01f;
            yield return new WaitForSeconds(0.1f);
        }

        img.fillAmount = 1;
    }

}
