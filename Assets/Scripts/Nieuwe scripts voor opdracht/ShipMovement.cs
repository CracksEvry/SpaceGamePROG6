using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}