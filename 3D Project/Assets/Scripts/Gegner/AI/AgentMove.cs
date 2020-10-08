using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    [SerializeField]
    Transform _Ziel;

    NavMeshAgent _navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        if(_navMeshAgent == null)
        {
            Debug.Log("the nav Mesh agent component is not attached to: " + gameObject.name);
        }
        else
        {
            SetzeZiel();
        }
    }

    private void SetzeZiel()
    {
        if(_Ziel != null)
        {
            Vector3 target = _Ziel.transform.position;
            _navMeshAgent.SetDestination(target);
        }
        else
        {
            Debug.Log("Der Nav Mesh Agent hat kein Ziel gesetzt: " + gameObject.name);
        }
    }
}
