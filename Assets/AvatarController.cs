using UnityEngine;
using System.Collections;

public class AvatarController : MonoBehaviour {

    private GameObject []texturas;
    public Transform avatar1;
    public Transform avatar2;
    public Transform avatar3;
    public Transform avatar4;
    public Transform avatar5;
    public Transform avatar6;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    private Transform posGuardada;
    public float speed=0.1f;
    public bool girarIzquierda = false;
    public bool girarDerecha = false;

    // Use this for initialization
    void Start()
    {
      
    }

    public void Slider_Changed(float newValue) {
        newValue = 1 - newValue;
        texturas = GameObject.FindGameObjectsWithTag("Textura");
        foreach (GameObject textura in texturas)
        {

            Renderer rend = textura.GetComponent<Renderer>();
            Color nuevo = new Color(newValue * (1 - (0.1f * newValue * newValue)), newValue * newValue, newValue * newValue * 0.8f, 255F);
            rend.material.color = nuevo;
            print("r: " + nuevo.r*255 + ", g: " + nuevo.g*255 + ", b: "+ nuevo.b* 255 + " new value: " + (1-newValue));
        }
        
    }

   public void girarIzq() {
       
        girarDerecha = false;
        girarIzquierda = true;
    }

    public void girarDere()
    {
        girarIzquierda = false;
        girarDerecha = true;
    }
    public void mundoVirtual() {
        Application.LoadLevel("FIA 5 kevin T");
    }

    void Update()
    {
        if (girarIzquierda) {
            float step = speed * Time.deltaTime;
            avatar1.position = Vector3.MoveTowards(avatar1.position, pos2.position, step);
            avatar2.position = Vector3.MoveTowards(avatar2.position, pos3.position, step);
            avatar3.position = Vector3.MoveTowards(avatar3.position, pos4.position, step);
            avatar4.position = Vector3.MoveTowards(avatar4.position, pos5.position, step);
            avatar5.position = Vector3.MoveTowards(avatar5.position, pos6.position, step);
            avatar6.position = Vector3.MoveTowards(avatar6.position, pos1.position, step);
        }

        if (girarDerecha)
        {
            Debug.Log("llegó");
            float step = speed * Time.deltaTime;
            avatar1.position = Vector3.MoveTowards(avatar1.position, pos1.position, step);
            avatar2.position = Vector3.MoveTowards(avatar2.position, pos2.position, step);
            avatar3.position = Vector3.MoveTowards(avatar3.position, pos3.position, step);
            avatar4.position = Vector3.MoveTowards(avatar4.position, pos4.position, step);
            avatar5.position = Vector3.MoveTowards(avatar5.position, pos5.position, step);
            avatar6.position = Vector3.MoveTowards(avatar6.position, pos6.position, step);
        }




    }



}
