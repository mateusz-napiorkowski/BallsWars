using UnityEngine;
using Photon.Pun;

public class steeringCamera : MonoBehaviour
{
    private Camera Camera;
    public float speed = 0.6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public float sensitivity = 20f;
    PhotonView view;
    // Update is called once per frame

    private void Start(){
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if(view.IsMine){
            Camera = GameObject.Find("MainCamera").GetComponent<Camera>();
            float xDir = Input.GetAxisRaw("Horizontal");
            float mouseX = Input.GetAxisRaw("Mouse X");
            float mouseY = -1 * Input.GetAxisRaw("Mouse Y");
            float zDir = Input.GetAxisRaw("Vertical");
            float playersforward = transform.localRotation.eulerAngles.z;
            float playersup = transform.localRotation.eulerAngles.y;
            float playersright = transform.localRotation.eulerAngles.x;
            Vector3 moveDir = new Vector3(xDir, 0f, zDir).normalized;
            Vector3 CurrRotation = new Vector3(playersright, playersup, playersforward);
            transform.Rotate(mouseY * sensitivity, mouseX * sensitivity, 0f, Space.Self);    //ruch kamerą
    
            if (moveDir.magnitude >= 0.1f){
                float targetAngle = Mathf.Atan2(moveDir.x, moveDir.z) * Mathf.Rad2Deg;
                float targetAngle2 = Mathf.Atan2(moveDir.x, playersup) * Mathf.Rad2Deg + playersforward;
                Vector3 moveDir2 = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                moveDir2 = Quaternion.Euler(CurrRotation) * moveDir2;
                print(moveDir2);
                transform.position += moveDir2.normalized * speed * Time.deltaTime ;
            }
        }

        
    }
}