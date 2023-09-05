using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private PlayerEventController playerEventController;
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private SpriteRenderer characterRender;
    [SerializeField] private Transform armPivot;
    // Start is called before the first frame update

    private void Awake()
    {
        playerEventController = GetComponent<PlayerEventController>();
    }

    void Start()
    {
        playerEventController.OnLookEvent += Look;
    }

    private void Look(Vector2 direction)
    {
        float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
        if (Mathf.Abs(angle) > 90f)
        {
            armRenderer.flipY = true;
        }
        else armRenderer.flipY= false;
        characterRender.flipX = armRenderer.flipY;
        armPivot.rotation = Quaternion.Euler(0, 0, angle);
        //Debug.Log(angle);
    }

}
