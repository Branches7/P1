using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemy : MonoBehaviour
{

    public GameObject[] enemy;
    public float spawnTime = 3f;            // How long between each spawn.
    public GameObject imagem;
    public float tempoMinimo = 1.3f;


    bool stt;
    bool criar = true;
    float tempo = 0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Update()
    {
        if(ScoreManager.score > (tempo + 10))
        {
            tempo = ScoreManager.score;
            if (spawnTime >= tempoMinimo) spawnTime -= 0.2f;
        }
    }

    // Update is called once per frame

    void Spawn()
    {
        stt = imagem.GetComponent<DefaultTrackableEventHandler>().temImagem;
        if (stt)
        {
            int sorteio = Random.Range(0, 4);
            GameObject a = Instantiate(enemy[sorteio], transform.position, transform.rotation) as GameObject;
            a.transform.parent = GameObject.Find("ImageTarget").transform;
        }

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.

    }
}
