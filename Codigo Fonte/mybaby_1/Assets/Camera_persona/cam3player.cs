using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam3player : MonoBehaviour
{

   
    public GameObject cabeca;
    public GameObject[] posicoes;
    public int indice = 0;
    public float VelocidadeDeMovimento = 2;
    private RaycastHit hit;

    private void FixedUpdate()
    {
        transform.LookAt(cabeca.transform);
        //checar se tem colisor
        if (!Physics.Linecast(cabeca.transform.position, posicoes[indice].transform.position))
        {
            transform.position = Vector3.Lerp(transform.position, posicoes[indice].transform.position, VelocidadeDeMovimento * Time.deltaTime);
            Debug.DrawLine(cabeca.transform.position, posicoes[indice].transform.position);
        }
        else if(Physics.Linecast(cabeca.transform.position, posicoes[indice].transform.position,out hit))
         {
        transform.position = Vector3.Lerp(transform.position, hit.point,(VelocidadeDeMovimento*2)*Time.deltaTime);
        Debug.DrawLine(cabeca.transform.position, hit.point);
        }

      // void Update()
       // {
          //  if (Input.GetKeyDown("e") && (indice < posicoes.Length - 1))
           // {
              //  indice++;
          //  }else if(Input.GetKeyDown("e") && indice >= (posicoes.Length - 1))
           // {
                //indice = 0;
            //}
       // }


        }


    }

        
    

   

