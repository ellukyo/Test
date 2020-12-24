using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ArmyController : MonoBehaviour
{

   // public Material a1;
    //public Material a2;
    public NavMeshAgent agent;// 存Agent的變數
    public GameObject Army;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //把Agent存起來以后用

    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) // start touching
         {
             Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position); // 產生觸碰點到場景上的ray  


             if (Physics.Raycast(ray, out RaycastHit hitInfo)) //取得射綫碰撞資訊
             {
                 GameObject target = hitInfo.collider.gameObject; //取得碰撞物

               MeshRenderer mr = target.GetComponent<MeshRenderer>(); //取得碰撞物的render

                 if (mr.sharedMaterial != a1)//比較材質是否是a1，不是的話就換，是的話換a2
                     mr.sharedMaterial = a1;
                 else
                     mr.sharedMaterial = a2;


             }


         }*/


        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) // start touching
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position); // 產生觸碰點到場景上的ray  


            if (Physics.Raycast(ray, out RaycastHit hitInfo)) //取得射綫碰撞資訊
            {
                GameObject army = hitInfo.collider.gameObject; //取得碰撞物


                Rigidbody rb = agent.GetComponent<Rigidbody>();//取得碰撞物的物理
                //rb.AddForce(new Vector3(0, 05f));// 推

                if (army.tag == "Groud") //如果碰撞物是地板
                {
                    agent.SetDestination(hitInfo.point);//讓Agent走去碰撞點
                }
            }
        }

    }

}

       

