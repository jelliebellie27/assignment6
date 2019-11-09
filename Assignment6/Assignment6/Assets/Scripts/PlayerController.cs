using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public int count;

    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    void start()
    {
        agent.updateRotation = false;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        PlayerPrefs.SetInt("score", count);
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }else
        {
            character.Move(Vector3.zero, false, false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect")
        {
            other.gameObject.SetActive(false);
            count++;
            
        }
        
    }
}
