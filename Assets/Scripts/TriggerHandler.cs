using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponState
{
    isKnife,
    isAxe
}

public class TriggerHandler : MonoBehaviour
{
    public bool isKnife, isAxe;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isKnife){EventsManager.Instance.KnifePortal();}
            if (isAxe) {EventsManager.Instance.AxePortal();}
            
        }
    }
}
