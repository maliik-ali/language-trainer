using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace FM
{
    public class ScanHandler : MonoBehaviour
    {
        public GameObject[] items;
        public GameObject shape;

        private void OnEnable()
        {
            TrackableEventHandler.onTargetFound += OnFound;
            TrackableEventHandler.onTargetLost += OnLoss;
        }

        private void OnDisable()
        {
            TrackableEventHandler.onTargetFound -= OnFound;
            TrackableEventHandler.onTargetLost -= OnLoss;
        }

        public void OnFound()
        {
            StartCoroutine("PlayAnimation");
        }


        IEnumerator PlayAnimation()
        {
            int i = 0;
            int iLength = items.Length;
            while (i < iLength)
            {
                items[i].SetActive(true);
                yield return new WaitForSeconds(0.3f);
                i++;
            }
            yield return 0;
        }

        public void OnLoss()
        {
            StopCoroutine("PlayAnimation");
            foreach (var item in items)
            {
                item.SetActive(false);
            }
            shape.SetActive(false);
        }

    }
}
