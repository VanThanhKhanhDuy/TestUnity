using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private Transform Player;

    private bool Lane1 = false;
    private bool Lane2 = true;

    private void Start()
    {
        Player = GetComponent<Transform>();
    }

    private void Update()
    {
        #region ChangeBools
        if (Input.GetKeyDown(KeyCode.RightArrow) && Lane1 == true)
        {
            Lane2 = true;
            Lane1 = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && Lane2 == true && Player.position.z <= 0.2f)
        {
            Lane1 = true;
            Lane2 = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && Lane2 == true && Player.position.z >= -0.2f)
        {
            Lane1 = false;
            Lane2 = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && Lane1 == false)
        {
            Lane2 = true;
            Lane1 = false;
        }
        #endregion
    }
}