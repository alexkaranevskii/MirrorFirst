using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Singletone
    private static InputManager _instance;

    public static InputManager Instance
    {
        get { return _instance; }
    }
    #endregion

    private Vector3 movementVector = new Vector3();
    private Player playerObj;
    private void Awake()
    {
        _instance = this;
    }

    void Update()
    {
        MoveInput();
    }

    public void SetPlayer(Player pl)
    {
        playerObj = pl;
    }

    #region Mooving
    private void MoveInput()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.z = Input.GetAxis("Vertical");
    }
    #endregion
}
