using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinks : MonoBehaviour
{
    public GameObject RessourcenMenü;
    public GameObject BasisMenü;
    public void Ressourcen_Button()
    {
        RessourcenMenü.SetActive(true);
        BasisMenü.SetActive(false);
    }
    public void Basis_Button()
    {
        RessourcenMenü.SetActive(false);
        BasisMenü.SetActive(true);
    }
}
