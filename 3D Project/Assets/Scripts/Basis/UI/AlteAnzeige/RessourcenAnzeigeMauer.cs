using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class RessourcenAnzeigeMauer : MonoBehaviour
{
    private Camera camera;
    public Canvas canvas;
    public GameObject Player;
    public TextMeshProUGUI AnzeigeText;
    public BoxCollider[] WallCollider;
    private int currentLVL;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        Player = GameObject.FindGameObjectWithTag("Player");
        canvas.GetComponent<Canvas>();
        AnzeigeText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
         currentLVL = SaveData.currnet.Mauer1.currentLVL;
        

        if(PlayerController.rayCast.collider == WallCollider[currentLVL] && PlayerController.rayCast.distance < 10)
        {
            MoveAndRotate();
            
        }
        else
        {
            canvas.enabled = false;
        }
    }

    private void MoveAndRotate()
    {
        //Anzeige wird Aktiviert
        canvas.enabled = true;

        //Anziege Dreht sich zum Spieler
        transform.LookAt(transform.position + camera.transform.rotation * Vector3.back, camera.transform.rotation * Vector3.up);
        //Setzt die Position auf das Crosshair + offset
       
        Vector3 Crosshairpos = new Vector3(PlayerController.rayCast.point.x, PlayerController.rayCast.point.y, PlayerController.rayCast.point.z);
        
        transform.position = Vector3.MoveTowards(transform.position, Crosshairpos, 0.5f);

        //Berechnet die Distanz und passt darauf die Größe an
        float Distanz = Vector3.Distance(this.transform.position, Player.transform.position) / 8;
        
        AnzeigeText.fontSizeMax = 0.3f;
        AnzeigeText.fontSizeMin = 0.1f;
        transform.localScale = new Vector3(Distanz / 2, Distanz, Distanz);
        
        AnzeigeText.fontSize = Distanz;
    }
}
