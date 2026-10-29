using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CuentaRegresivaClase : MonoBehaviour
{
    [Header("Referencias de UI")]
    public TextMeshProUGUI textoCuenta;
    public GameObject imagenYa;

    [Header("Configuración de Audio")]
    public AudioSource audioSourceSFX;
    public AudioClip clipBeep;         
    public AudioClip clipYa;           

    [Header("Configuración de Audio (Música)")]
    public AudioSource audioSourceMusica;
    public AudioClip clipMusicaJuego;  

    void Start()
    {
        if (imagenYa != null)
        {
            imagenYa.SetActive(false);
        }
        StartCoroutine(RutinaCuentaRegresiva());
    }

    IEnumerator RutinaCuentaRegresiva()
    {
        textoCuenta.text = "3";
        audioSourceSFX.PlayOneShot(clipBeep);
        yield return new WaitForSeconds(1f);

        textoCuenta.text = "2";
        audioSourceSFX.PlayOneShot(clipBeep);
        yield return new WaitForSeconds(1f);

        textoCuenta.text = "1";
        audioSourceSFX.PlayOneShot(clipBeep);
        yield return new WaitForSeconds(1f);

        textoCuenta.text = "¡Ya!";
        audioSourceSFX.PlayOneShot(clipYa);

        if (imagenYa != null)
        {
            imagenYa.SetActive(true);
        }

        audioSourceMusica.clip = clipMusicaJuego;
        audioSourceMusica.loop = true;
        audioSourceMusica.Play();

        yield return new WaitForSeconds(1f);

        textoCuenta.text = "";
    }
}