using System;
using Moe.Tools;
using UnityEngine;

public class KeyLogic : MonoBehaviour
{
    public GameObject FindKeyUiAndLogic;
    public GameObject KeyObject;
    public GameObject FinishBlocker;

    void OnJointBreak(float breakForce)
    {
        DestroyKey();
        OpenExit();
    }


    private void DestroyKey()
    {
        FindKeyUiAndLogic.SetActive(true);
        Destroy(FindKeyUiAndLogic, 2);
        Destroy(KeyObject, 1);
    }

    private void OpenExit()
    {
        Destroy(FinishBlocker);
    }
}
