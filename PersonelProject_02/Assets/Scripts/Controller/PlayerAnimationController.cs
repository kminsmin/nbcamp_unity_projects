using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]private Animator m_Animator;
    private Rigidbody2D m_Rigidbody;
    // Start is called before the first frame update
    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        m_Animator.SetInteger("avatarAnim", PlayerPrefs.GetInt("PlayerAvatar"));
    }


    // Update is called once per frame
    void Update()
    {
        if (m_Rigidbody.velocity.magnitude > 0)
        {
            m_Animator.SetBool("isMoving", true);
        }
        else
            m_Animator.SetBool("isMoving", false);
    }

    public void ChangeCharacterAvatar()
    {
        m_Animator.SetInteger("avatarAnim", PlayerPrefs.GetInt("PlayerAvatar"));
    }

}
