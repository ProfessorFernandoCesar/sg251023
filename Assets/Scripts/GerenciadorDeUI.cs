using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorDeUI : MonoBehaviour
{


    public Sprite[] vidas;


    public Image mostrarImagemDasVidas;

     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtualizarVidas(int vidasAtuais)
    {

        mostrarImagemDasVidas.sprite = vidas[vidasAtuais];

    }





}
