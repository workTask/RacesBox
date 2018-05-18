using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform player;

	void Start () {
		Debug.Log("Hello FollowPlayer");
	}
	
	
	void Update () {
		Debug.Log("player.position"+player.position);
		Debug.Log("transform.position "+transform.position);
		
		transform.position = player.position;
	}
}
