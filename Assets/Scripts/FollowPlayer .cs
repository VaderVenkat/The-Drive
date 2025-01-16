using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 CamOffSet = new Vector3(0f, 5f, -8f);
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Vehicle").transform;
    }

    private void LateUpdate()
    {
        this.transform.position = player.TransformPoint(CamOffSet);
        this.transform.LookAt(player);
    }
}
    