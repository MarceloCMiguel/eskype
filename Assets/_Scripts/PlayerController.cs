using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   public float _baseSpeed = 5.0f;

    CharacterController characterController;

   //Referência usada para a câmera filha do jogador
   GameObject playerCamera;
   //Utilizada para poder travar a rotação no angulo que quisermos.
   float cameraRotation;
    Rigidbody rb;
    private bool groundedPlayer;
    private Vector3 playerVelocity;
private float jumpHeight = 1.0f;
private float gravityValue = -9.81f;


   void Start()
   {
       characterController = GetComponent<CharacterController>();
       playerCamera = GameObject.Find("Main Camera");
       cameraRotation = 0.0f;
       rb = GetComponent<Rigidbody>();

   }

   void Update()
   {

       groundedPlayer = characterController.isGrounded;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Pause");
        }
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        Vector3 direction = transform.right * move.x * _baseSpeed + transform.up * 1 + transform.forward * move.z * _baseSpeed;

        playerVelocity.y += gravityValue * Time.deltaTime;
        direction.y = playerVelocity.y;
        characterController.Move(direction * Time.deltaTime);

                 //Tratando movimentação do mouse
       float mouse_dX = Input.GetAxis("Mouse X");
       float mouse_dY = Input.GetAxis("Mouse Y");

        //Tratando a rotação da câmera
       cameraRotation -= mouse_dY;
       Mathf.Clamp(cameraRotation, -75.0f, 75.0f);
    //    characterController.Move(direction * _baseSpeed * Time.deltaTime);
       transform.Rotate(Vector3.up, mouse_dX);
       playerCamera.transform.localRotation = Quaternion.Euler(cameraRotation, 0.0f, 0.0f);
       
   }
}
