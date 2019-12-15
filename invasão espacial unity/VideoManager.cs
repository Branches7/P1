using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer video;
    Image imagem;
    public Color cor;//= new Color(0f, 0f, 0f, 150f);
    Color cor2 = new Color(0f, 0f, 0f, 255f);
    Text corBotaoLetra;
    public float flashSpeed;
    bool teste = false;
    public GameObject botao;
    public GameObject Pular;
    void Awake()
    {
        imagem = botao.GetComponent<Image>();
        corBotaoLetra = botao.GetComponentInChildren<Text>();
        botao.SetActive(false);
        Pular.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!video.isPlaying && teste)
        {
            Pular.SetActive(false);
            botao.SetActive(true);
            imagem.color = Color.Lerp(imagem.color, cor, flashSpeed * Time.deltaTime);
            corBotaoLetra.color = Color.Lerp(corBotaoLetra.color, cor2, flashSpeed * Time.deltaTime*0.5f);
        }
        else
        {
            botao.SetActive(false);
            Pular.SetActive(true);
            imagem.color = Color.clear;
            corBotaoLetra.color = Color.clear;
            teste = true;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
