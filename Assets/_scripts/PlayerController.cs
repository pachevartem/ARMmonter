using System;
using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace MonterProject
{
    public class PlayerController : MonoBehaviour
    {
        private Animator _anim;
        public  enum STATEHERO
        {
            IDLE,RUN,WORK
        }
        public  STATEHERO state
        {
            set {
                switch (value)
                {
                    case STATEHERO.IDLE:
                        _anim.SetTrigger("idle");
                        break;
                    case STATEHERO.RUN:
                        _anim.SetTrigger("run");
                        break;
                    case STATEHERO.WORK:
                        _anim.SetTrigger("work");
                        break;
                }
            }
        }

  

        protected void Awake()
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
        public IEnumerator ChekPiontEventEnumerator(Vector3 target, STATEHERO statehero)
        {
            while (transform.position != target)
            {
                yield return new WaitForSeconds(0.1f);
                //print("Ienumerator "+ gameObject.name.ToString());
            }
            state = statehero;
            MethodEndWalk();
        }

        public void MoveTo(string pathName, int timeWalk, STATEHERO statehero)
        {
            _anim.SetTrigger("run");
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(pathName), "time", timeWalk, "easetype", iTween.EaseType.linear, "orienttopath", true));
            var lastPoint = iTweenPath.GetPath(pathName)[iTweenPath.GetPath(pathName).Length - 1];
            
            StartCoroutine(ChekPiontEventEnumerator(lastPoint, statehero));
        }
        public void MoveTo(string pathName, int timeWalk)
        {
             MoveTo(pathName, timeWalk, STATEHERO.WORK);
        }
        public void MoveTo(string pathName)
        {
            MoveTo(pathName, 2, STATEHERO.WORK);
        }

        public virtual void MethodEndWalk()
        {

        }

    }
}
