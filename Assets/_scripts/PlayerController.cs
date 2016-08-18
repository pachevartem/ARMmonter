using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace MonterProject
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject InsPetarda;
        public GameObject InsShieldYellow;
        public GameObject InsShieldRed;
        private Animator _anim;
        public enum STATEHERO
        {
            IDLE,RUN,WORK
        }

        public STATEHERO state = STATEHERO.IDLE;

        public delegate void ChekPosition();
        public static event ChekPosition CheckTarget = delegate {};

        void Start()
        {
            _anim = GetComponent<Animator>();
        }

        /// <summary>
        /// Создает инструмент
        /// </summary>
        /// <param name="item"></param>
        public void CreateInstrument(GameObject item)
        {
            Instantiate(item, this.transform.position, Quaternion.identity);
        }

        void Update()
        {
            
        }

        void ChangeAnimation(STATEHERO statehero)
        {
            switch (statehero)
            {
                    case STATEHERO.IDLE:
                    print("я стою");
                    _anim.SetTrigger("idle");

                    break;
                    case STATEHERO.RUN:
                    print("я бегу");
                    _anim.SetTrigger("run");
                    break;
                    case STATEHERO.WORK:
                    print("я работаю");
                    _anim.SetTrigger("work");
                    break;
            }
        }

        public IEnumerator ChekPiontEventEnumerator(Vector3 target)
        {
            while (transform.position != target)
            {
                yield return new WaitForSeconds(0.1f);
            }
            CheckTarget();
        }


    }
}
