using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testfile : MonoBehaviour
{
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) // start touching
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position); // 產生觸碰點到場景上的ray  


            if (Physics.Raycast(ray, out RaycastHit hitInfo)) //取得射綫碰撞資訊
            {
                GameObject army = hitInfo.collider.gameObject; //取得碰撞物

                if (army.tag == "Groud")
                {
                    agent.SetDestination(hitInfo.point);
                }
            }
        }

    }

}