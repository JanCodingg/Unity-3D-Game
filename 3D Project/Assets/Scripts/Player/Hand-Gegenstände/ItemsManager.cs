using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    private int ZahlDesItems = 1;
    [SerializeField]
    private GameObject[] GegenständeAry;

    internal static GameObject[] GegenständeAryStatic;
    // Start is called before the first frame update
    void Start()
    {
        GegenständeAryStatic = GegenständeAry;
        SwitchItem();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ZahlDesItems = 1;
            SwitchItem();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ZahlDesItems = 2;
            SwitchItem();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ZahlDesItems = 3;
            SwitchItem();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ZahlDesItems = 4;
            SwitchItem();

        }
    }

    private void SwitchItem()
    {
        switch (ZahlDesItems)
        {
            case 1:
                foreach (GameObject Gegenstand in GegenständeAry)
                {
                    Gegenstand.SetActive(false);
                }
                GegenständeAry[0].SetActive(true);
                break;
            case 2:
                foreach (GameObject Gegenstand in GegenständeAry)
                {
                    Gegenstand.SetActive(false);
                }
                GegenständeAry[1].SetActive(true);
                break;
            case 3:
                foreach (GameObject Gegenstand in GegenständeAry)
                {
                    Gegenstand.SetActive(false);
                }
                GegenständeAry[2].SetActive(true);
                break;
            case 4:
                foreach(GameObject Gegenstand in GegenständeAry)
                {
                    Gegenstand.SetActive(false);
                }
                GegenständeAry[3].SetActive(true);
                break;
            default:
                foreach (GameObject Gegenstand in GegenständeAry)
                {
                    Gegenstand.SetActive(false);
                }
                GegenständeAry[0].SetActive(true);
                break;
        }
    }
}
