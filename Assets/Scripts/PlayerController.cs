using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float defaultMoveSpeed;
    [SerializeField] private TransformVariable playerTransform;
    private Rigidbody rb;

    private float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = defaultMoveSpeed;
    }

    void FixedUpdate()
    {
        Move();
        Rotate();

        playerTransform.transform = transform;
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(horizontal, 0, vertical).normalized;

        rb.AddForce(moveVector * moveSpeed);
    }

    private void Rotate()
    {
        //cast ray from mouse
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        //create plane that detects ray
        Plane groundPlane = new Plane(Vector3.up, new Vector3(0, -1.1f, 0)); //1.1f = world y of ground
        float rayLength;

        if(groundPlane.Raycast(mouseRay, out rayLength))
        {
            //get point where ray intersects with ground
            Vector3 pointToLookAt = mouseRay.GetPoint(rayLength);
            //rotate, do not include y to avoid y axis movement
            transform.LookAt(new Vector3(pointToLookAt.x, transform.position.y, pointToLookAt.z));
        }
    }
}
