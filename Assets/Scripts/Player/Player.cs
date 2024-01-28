using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPose;
    [SerializeField] int currentPoseIndex = 0;

    private void Start()
    {
        // Ensure that at least one player mpose is assigned
        if (playerPose.Length > 0)
        {
            // Activate the initial player model
            SwitchPlayerPose(currentPoseIndex);
        }
        else
        {
            Debug.LogError("No player pose assigned!");
        }
    }

    private void Update()
    {

        if (!GameManager.Instance.IsGameOver())
        {
            // Example: Switch player model when the q key is pressed
            if (Input.GetKeyDown(KeyCode.Q))
            {
                currentPoseIndex = 0;

                // Switch to the new player model
                SwitchPlayerPose(currentPoseIndex);
            }

            // Example: Switch player model when the w key is pressed
            if (Input.GetKeyDown(KeyCode.W))
            {
                currentPoseIndex = 1;

                // Switch to the new player model
                SwitchPlayerPose(currentPoseIndex);
            }

            // Example: Switch player model when the a key is pressed
            if (Input.GetKeyDown(KeyCode.A))
            {
                currentPoseIndex = 2;

                // Switch to the new player model
                SwitchPlayerPose(currentPoseIndex);
            }

            // Example: Switch player model when the d key is pressed
            if (Input.GetKeyDown(KeyCode.D))
            {
                currentPoseIndex = 3;

                // Switch to the new player model
                SwitchPlayerPose(currentPoseIndex);

            }

            // Example: Switch player model when the s key is pressed
            if (Input.GetKeyDown(KeyCode.S))
            {
                currentPoseIndex = 4;

                // Switch to the new player model
                SwitchPlayerPose(currentPoseIndex);
            }


            // Example: Switch player model when the e key is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {

                currentPoseIndex = 5;

                // Switch to the new player model
                SwitchPlayerPose(currentPoseIndex);
            }
        }
    }

    private void SwitchPlayerPose(int newIndex)
    {
        // Deactivate current player model
        for (int i = 0; i < playerPose.Length; i++)
        {
            playerPose[i].SetActive(i == newIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            GameManager.Instance.SetGameOver();
        }
    }
    
}
