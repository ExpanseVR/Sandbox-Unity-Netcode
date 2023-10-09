using Unity.Netcode;
using UnityEngine;

namespace Runtime.Network
{
    public class TransferOwnership : NetworkBehaviour
    {
        [SerializeField] private ulong clientId;
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.A))
                NetworkObject.ChangeOwnership(clientId);
        }
    }
}

