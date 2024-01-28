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
            SwitchPlayerModel(currentPoseIndex);
        }
        else
        {
            Debug.LogError("No player pose assigned!");
        }
    }

    private void Update()
    {

        if (!GameManager.Instance.IsGameOver()){

        // Example: Switch player model when the space key is pressed
        if (Input.GetKeyDown(KeyCode.Q))

        {
            // Example: Switch player model when the space key is pressed
            if (Input.GetKeyDown(KeyCode.W))
            {
                // Increment index to switch to the next player model
                currentPoseIndex = 0;

                // Switch to the new player model
                SwitchPlayerModel(currentPoseIndex);
            }


        // Example: Switch player model when the space key is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Increment index to switch to the next player model
            currentPoseIndex = 1;

                // Switch to the new player model
                SwitchPlayerModel(currentPoseIndex);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Increment index to switch to the next player model
            currentPoseIndex = 2;

            // Switch to the new player model
            SwitchPlayerModel(currentPoseIndex);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Increment index to switch to the next player model
            currentPoseIndex = 3;

            // Switch to the new player model
            SwitchPlayerModel(currentPoseIndex);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Increment index to switch to the next player model
            currentPoseIndex = 4;

            // Switch to the new player model
            SwitchPlayerModel(currentPoseIndex);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Increment index to switch to the next player model
            currentPoseIndex = 5;

            // Switch to the new player model
            SwitchPlayerModel(currentPoseIndex);
        }
    }

    private void SwitchPlayerModel(int newIndex)
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
}
