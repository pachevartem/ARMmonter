using UnityEngine;
using System.Collections;

namespace MonterProject
{
    public class ItemController : MonoBehaviour
    {
        public GameObject item;

        void OnTriggerEnter(Collider _col)
        {
            if (_col.tag == "Player")
            {
                _col.gameObject.GetComponent<Animator>().SetTrigger("work");
                Instantiate(item, this.transform.position, Quaternion.identity);
            }
        }
        void OnTriggerExit(Collider _col)
        {
            _col.gameObject.GetComponent<Animator>().SetTrigger("run");
        }

    }
}
