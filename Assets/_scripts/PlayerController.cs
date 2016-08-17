using UnityEngine;
using System.Collections;

namespace MonterProject
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject InsPetarda;
        public GameObject InsShieldYellow;
        public GameObject InsShieldRed;

     /// <summary>
     /// Создает инструмент
     /// </summary>
     /// <param name="item"></param>
        public void CreateInstrument(GameObject item)
        {
            Instantiate(item, this.transform.position, Quaternion.identity);
        }



    }
}
