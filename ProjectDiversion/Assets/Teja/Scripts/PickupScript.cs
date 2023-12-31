using UnityEngine;

public class PickupScript : MonoBehaviour
{
    [SerializeField] private Transform playercameratransform;
    [SerializeField] private LayerMask pickuplayermasl;
    [SerializeField] private Transform objectgrabpointtransform;
    

    private Picables pickables;


    private void Update()
    {
       

        if (Input.GetKeyUp(KeyCode.E))
        {
            if (pickables == null)
            {

                float pickupidis = 10f;

                if (Physics.Raycast(playercameratransform.transform.position, playercameratransform.forward, out RaycastHit raycasthit, pickupidis, pickuplayermasl))
                {
                    Debug.Log(raycasthit.transform);

                    if (raycasthit.transform.TryGetComponent(out pickables))
                    {
                        pickables.Grab(objectgrabpointtransform);

                        Debug.Log(pickables);
                    }
                }

            }
            else
            {
                pickables.drop();
                pickables = null;
            }

        }
    }


   
   


}

