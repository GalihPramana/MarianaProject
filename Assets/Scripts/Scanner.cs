using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public float scanRange = 10f;
    public Camera playerCamera;
    public LayerMask scanLayer;            
    public UIManager uiManager;             

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Scan();
        }
    }

    void Scan()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, scanRange, scanLayer))
        {
            HewanLaut creature = hit.collider.GetComponent<HewanLaut>();
            if (creature != null)
            {
                Debug.Log("Scan kena: " + creature.creatureName);
                uiManager.ShowCreatureInfo(creature);
            }
            else
            {
                Debug.Log("Ray kena object, tapi bukan HewanLaut");
            }
        }
        else
        {
            Debug.Log("Ray tidak kena apa-apa");
        }
    }

}