using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    private float _velocidade = 6.0f;

    [SerializeField]
    private GameObject _explosaoDoInimigo;

    private GerenciadorDeUI _gerenciadorDeUI;

    void Start()
    {
        _gerenciadorDeUI = GameObject.Find("Canvas").GetComponent<GerenciadorDeUI>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * _velocidade * Time.deltaTime);


        if ( transform.position.y < -6.0f)
        {
            transform.position = new Vector3(Random.Range(-7.7f, 7.7f), 6.0f, 0);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("O objeto " + name + " colidiu com o objeto " + other.name);

        if ( other.tag == "Tiro")
        {
            Destroy(other.gameObject);

            _gerenciadorDeUI.AtualizarPlacar();

        }

        if ( other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPlayer();
            }

        }

        Destroy(this.gameObject);

        Instantiate(_explosaoDoInimigo, transform.position, Quaternion.identity);

    }
}
