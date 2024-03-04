using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Hastighet f�r spelarens r�relse

    void Update()
    {
        // H�mta raw input fr�n tangentbordet
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Ber�kna r�relsevektorn
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // Applicera r�relsen p� spelaren
        transform.Translate(movement);
    }
}