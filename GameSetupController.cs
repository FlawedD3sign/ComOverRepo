using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetupController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }

    // Update is called once per frame
private void CreatePlayer()
    {
       Debug.Log("Creating Player");
       PhotonNetwork.Instantiate(Path.Combine("models", "remy@Idle"), Vector3.zero, Quaternion.identity);
    }
}
