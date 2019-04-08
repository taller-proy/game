using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texto : MonoBehaviour
{
    public GameObject voltimetro;
    // Start is called before the first frame update
    void Start()
    {
        voltimetro.SetActive(false);
    }

    public void OnMouseOver()
    {
        voltimetro.SetActive(true);
    }

    public void OnMouseExit()
    {
        voltimetro.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
