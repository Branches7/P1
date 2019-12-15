using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeInText : MonoBehaviour
{
    // Start is called before the first frame update
    Color corOriginal;
    Text texto;
    public float flashSpeed = 0.8f;
    void Awake()
    {
        texto = gameObject.GetComponent<Text>();
        corOriginal = texto.color;
        texto.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.active)
        {
            texto.color = Color.Lerp(texto.color, corOriginal, flashSpeed * Time.deltaTime);
        }
    }
}
