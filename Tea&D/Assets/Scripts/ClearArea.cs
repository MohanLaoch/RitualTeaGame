using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour
{
    public GameObject clearArea;

    public void AreaOnOff()
    {
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        clearArea.SetActive(true);
        yield return new WaitForSeconds(.1f);
        clearArea.SetActive(false);
    }
}
