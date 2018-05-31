using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class baby : MonoBehaviour {
    public float input;
    public float sensitility = 3;
    bool pressing;
    public float rotateSpeed = 3.0f;
    public float speed = 6.0f;

    public CharacterController controller; // controlador do baby
    public Animator animator; // controle de animaçoes

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        SetTransformX(0.021f);
        Rotacionar();
        Mover();
        rodarEsquerda();
        rodarDireita();
        andarParaTras();

        // var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        // var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //transform.Rotate(0, x, 0);
        //transform.Translate(0, 0, z);
        //float velocidadeDopersonagem = Mathf.Abs(x) + Mathf.Abs(z);
        // animator.SetFloat("velocidade", velocidadeDopersonagem);


    }
    private void andarParaTras()
    {
        if (
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.PageDown)
            )
        {
            animator.SetFloat("dandore", 2.0f);
            SetTransformX(0.021f);
        }
        if (Input.GetKeyUp(KeyCode.S) ||
                Input.GetKeyUp(KeyCode.LeftAlt))
        {
            animator.SetFloat("dandore", 0.0f);
            SetTransformX(0.021f);

        }
    }




    private void rodarEsquerda()
    {
        if (
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.LeftAlt)
            )
        {
            animator.SetFloat("rodando", 2.0f);
            SetTransformX(0.021f);
        }
        if (Input.GetKeyUp(KeyCode.A) ||
                Input.GetKeyUp(KeyCode.LeftAlt))
        {
            animator.SetFloat("rodando", 0.0f);
            SetTransformX(0.021f);

        }
    }

        private void rodarDireita()
        {
            if (
                Input.GetKey(KeyCode.D) ||
                Input.GetKey(KeyCode.RightAlt)
                )
            {
                animator.SetFloat("rodandodireita", 2.0f);
                SetTransformX(0.021f);
            }
            if (Input.GetKeyUp(KeyCode.D) ||
                    Input.GetKeyUp(KeyCode.RightAlt))
            {
                animator.SetFloat("rodandodireita", 0.0f);
                SetTransformX(0.021f);

            }

        }
        private void Mover()
        {
            var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(0, 0, z);
            //Vector3 vetorVelocidade = transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed;
            // controller.SimpleMove(vetorVelocidade);
            if (
                Input.GetKey(KeyCode.W) ||
               Input.GetKey(KeyCode.PageUp)) {
                SetTransformX(0.021f);
                animator.SetFloat("velocidade", 2.0f);
            }
            if (Input.GetKeyUp(KeyCode.W) ||
                Input.GetKeyUp(KeyCode.PageUp))
        {
            animator.SetFloat("velocidade", 0.0f);
            SetTransformX(0.021f);
            
            }
        }



        private void Rotacionar()
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        }
        void SetTransformX(float n)
        {
            transform.position = new Vector3(transform.position.x, n, transform.position.z);
        }


    }






