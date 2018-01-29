using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class PlayerController : Photon.MonoBehaviour {
    
    PhotonView view;

    [Header("Deplacement")]
    public float ID;

    [Header("Deplacement")]
    private float move_horizontal;
    private float move_vertical;
    private Vector3 move;
    public float playerSpeed;

    [Header("Animation")]
    public Animator anim;
    private bool canPlayAnim = true;
    private int animToPlay = 0;
    private GameObject interactible;

	
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
            PlayAnim();
    }

    void PlayAnim()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canPlayAnim && animToPlay != 0)
        {
            view.RPC("RPC_PerformTaunt", PhotonTargets.All);
        }
    }

    private void RPC_PerformTaunt()
    {
        anim.SetInteger("WeaponType_int", animToPlay);
        canPlayAnim = false;
        transform.rotation = Quaternion.LookRotation(interactible.transform.position);
        Invoke("StopAnim", 0.5f);
    }

    void StopAnim()
    {
        anim.SetInteger("WeaponType_int", 0);
        canPlayAnim = true;
    }

	void FixedUpdate ()
    {
        if (view.isMine)
        {
            move_horizontal = Input.GetAxis("Horizontal");
            move_vertical = Input.GetAxis("Vertical");
            if (anim.GetInteger("WeaponType_int") != 10)
            {
                move = new Vector3(move_horizontal, 0, move_vertical);
                transform.position += move * playerSpeed * Time.deltaTime;
            }
            if (move != Vector3.zero && canPlayAnim)
                transform.rotation = Quaternion.LookRotation(move);

            anim.SetFloat("Speed_f", move.magnitude);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Throw"))
        {
            animToPlay = 12;
            interactible = other.transform.parent.gameObject;
        }
        else if (other.CompareTag("Place"))
        {
            animToPlay = 10;
            interactible = other.transform.parent.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Throw") || other.CompareTag("Place"))
            animToPlay = 0;
    }

}
