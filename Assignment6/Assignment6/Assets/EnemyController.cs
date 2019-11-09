using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyControllerScript : MonoBehaviour
{
    public NavMeshAgent enemyAgent;
    public GameObject player;
    public int death;
    // Start is called before the first frame update
    private void Start()
    {
        enemyAgent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            death++;
            PlayerPrefs.SetInt("death", death);
        }
    }

}
