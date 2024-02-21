using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PortalUpdateManager : MonoBehaviour
{
    public CinemachineVirtualCamera VCam_1, VCam_2, VCam;
    public List<GameObject> Weapons = new();
    private int activeIndex;
    //public GameObject Axe, Knife;

    //CINEMACHINE

    private void OnEnable()
    {
        EventsManager.onAxePortal += AxeEnabled;
        EventsManager.onKnifePortal += KnifeEnabled;
        EventsManager.OnPlusOnePortal += PlusOnePlayer;
    }

    private void OnDisable()
    {
        EventsManager.onAxePortal -= AxeEnabled;
        EventsManager.onKnifePortal -= KnifeEnabled;
        EventsManager.OnPlusOnePortal -= PlusOnePlayer;
    }

    private void KnifeEnabled()
    {
        ToggleObject(0);
        VCam_2.Priority = 20;
        VCam_1.Priority = 13;
        //Knife.SetActive(true);
        //Axe.SetActive(false);
    }

    private void AxeEnabled()
    {
        ToggleObject(1);
        VCam_1.Priority = 20;
        VCam_2.Priority = 10;
        //Axe.SetActive(true);
        //Knife.SetActive(false);
    }

    private void PlusOnePlayer()
    {

    }

    void ToggleObject(int index)
    {
        //Deactivate all game object
        for (int i = 0; i < Weapons.Count; i++)
        {
            //Toggle the activation state based on the provided index
            Weapons[i].gameObject.SetActive(i == index?!Weapons[i].activeSelf:false) ;
        }
        activeIndex = index;
    }
}
