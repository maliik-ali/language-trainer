using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OpenLink : MonoBehaviour
{
    public string link;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenLinkOnClik);
    }

    private void OpenLinkOnClik()
    {
        Application.OpenURL(link);
    }

   
}
