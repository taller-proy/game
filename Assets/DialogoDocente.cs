using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogoDocente : MonoBehaviour {

    // Use this for initialization
    string message;
    public Text txtTutorial;
    public GameObject btnConsulta;
    public GameObject btnConsulta2;
    public GameObject btnConsulta3;
    public GameObject btnConsulta4;
    public GameObject btnConsulta5;
    public GameObject btnConsulta6;
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
      
	}

    void OnTriggerEnter()
    {
        StartCoroutine(Iniciar());
    }

    public void BotonConsultar() {
        StartCoroutine(BotonConsulta());
    }

    public void BotonConsultar2()
    {
        StartCoroutine(BotonConsulta2());
    }

    public void BotonConsultar3()
    {
        StartCoroutine(BotonConsulta2());
    }

    public void cambiarAvatar() {
        SceneManager.LoadScene("CrearAvatar");
    }

    IEnumerator Iniciar()
    {
        message = "Buenos días, Juan, por favor toma asiento al lado de tu compañera";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2);
        txtTutorial.text = "";
        message = "Buenos días alumnos. La clase de hoy va a tratar sobre los distintos tipos de ropa con los que vamos a trabajar. Conocer cada uno de ellos es importante para poder realizar un diseño óptimo";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(4);
        txtTutorial.text = "";
        message = "Para el final de la clase cada uno deberá ser capaz de reconocer las características de cada tipo de ropa y poder distinguirlas entre sí";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(4);
        txtTutorial.text = "";
        message = "Existen 3 tipos de ropas que utilizan los avatares para vestirse. Para poder diseñar correctamente lo que tenemos en mente debemos primeramente reconocer los tipos de ropa y elegir el más adecuado a nuestro proyecto. Vamos a ver a continuación las características de cada uno y cómo distinguirlos. Recuerden que si tienen alguna pregunta tienen toda la libertad para realizarla.";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        btnConsulta.SetActive(true);

    }

    IEnumerator BotonConsulta() {
        btnConsulta.SetActive(false);
        txtTutorial.text = "";
        message = "Parece que un estudiante tiene una consulta. ¿Qué necesitas saber, Juan?";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        btnConsulta2.SetActive(true);
        btnConsulta3.SetActive(true);

    }

    IEnumerator BotonConsulta2()
    {
        btnConsulta2.SetActive(false);
        btnConsulta3.SetActive(false);
        txtTutorial.text = "";
        message = "¡Claro! Les había comentado que existen 3 tipos de ropa que utilizan los avatares para vestirse. Para poder diseñar correctamente lo que tenemos en mente... (continúa explicando) \n ¿Le quedó más claro?";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        btnConsulta4.SetActive(true);
        btnConsulta5.SetActive(true);

    }

    IEnumerator BotonConsulta3()
    {
        btnConsulta4.SetActive(false);
        btnConsulta5.SetActive(false);
        txtTutorial.text = "";
        message = "¿Alguien más tiene una consulta?";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        btnConsulta6.SetActive(true);
        yield return new WaitForSeconds(4f);
        btnConsulta6.SetActive(false);
        txtTutorial.text = "";
        message = "Bien, continuemos, pero este tema es muy importante y es necesario que quede claro, no sean tímidos si tienen una duda";
        foreach (char letter in message.ToCharArray())
        {
            txtTutorial.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
