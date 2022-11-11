using UnityEngine;
using Photon.Pun;

public class steering : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    PhotonView view;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    // Update is called once per frame
    void Update(){
        if(view.IsMine){
            float xDir = Input.GetAxisRaw("Horizontal");
            float zDir = Input.GetAxisRaw("Vertical");
            float playersforward = cam.transform.localRotation.eulerAngles.x;
            Vector3 moveDir = new Vector3(xDir, 0f, zDir).normalized;

            if (moveDir.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(moveDir.x, moveDir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            Vector3 moveDir2 = Quaternion.Euler(playersforward, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir2.normalized * speed * Time.deltaTime);
            }
        }        
    }
}