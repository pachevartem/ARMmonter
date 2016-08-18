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
        private  Animator _anim;
        public  enum STATEHERO
        {
            IDLE,RUN,WORK
        }
        public  STATEHERO state
        {
            get { return state; }
            set {
                switch (value)
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
        }

        public delegate void ChekPosition(STATEHERO statehero);
        public static event ChekPosition CheckTarget = delegate {};

        void Awake()
        {
            CheckTarget += ChangeAnimation;
        }

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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = STATEHERO.WORK;
            }
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                state = STATEHERO.IDLE;
            }
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                state = STATEHERO.RUN;
            }
        }
        
        public IEnumerator ChekPiontEventEnumerator(Vector3 target, STATEHERO statehero)
        {
            while (transform.position != target)
            {
                yield return new WaitForSeconds(0.1f);
                print("Ienumerator");
            }
            CheckTarget(statehero);
        }


        void ChangeAnimation(STATEHERO statehero)
        {
            state = statehero;
        }

    }
}
