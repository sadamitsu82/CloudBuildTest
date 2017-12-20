using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainController : MonoBehaviour {



    void OnJoinedRoom()
    {
        CreatePlayerObject();
        //ChangeCamera();
    }

    void CreatePlayerObject()
    {
        float ranX= Random.Range(-10f, 10f);
        float ranZ = Random.Range(-40f, 20f);
        Vector3 position = new Vector3(ranX, 1f, ranZ);

        GameObject newPlayerObject = PhotonNetwork.Instantiate("Cars", position, Quaternion.identity, 0);

    }

    void ChangeCamera()
    {
        GameObject refObj = GameObject.Find("CameraSwitch");
        CameraSwitch cs = refObj.GetComponent<CameraSwitch>();
        cs.NextCamera();
    }
}
