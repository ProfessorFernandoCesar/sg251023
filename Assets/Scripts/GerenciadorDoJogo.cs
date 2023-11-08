using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDoJogo : MonoBehaviour
{

    public GameObject player;


    public bool fimDeJogo = true;


    private GerenciadorDeUI _gerenciadorUI;


    // Start is called before the first frame update
    void Start()
    {
        _gerenciadorUI = GameObject.Find("Canvas").GetComponent<GerenciadorDeUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fimDeJogo == true)
        {
            if ( Input.GetKeyDown(KeyCode.Space) ) {


                Instantiate(player,Vector3.zero, Quaternion.identity);
            
                fimDeJogo = false;

                _gerenciadorUI.EsconderTelaInicial();

            
            }


        }





    }
}
