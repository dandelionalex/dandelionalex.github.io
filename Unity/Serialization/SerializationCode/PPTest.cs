using UnityEngine;

public class PPTest : MonoBehaviour
{
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A DOWN");
            var settings = new StorageUN.GameSettings(){
                DeathsOnColonyEpidemic = 8,
                ColoniesAmount = 8
            };
            StorageUN.SaveData(settings);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B DOWN");
            var settings = StorageUN.LoadData<StorageUN.GameSettings>();
            Debug.Log( $"DeathsOnColonyEpidemic {settings.DeathsOnColonyEpidemic}" );
            Debug.Log( $"ColoniesAmount {settings.ColoniesAmount}" );
        }
    }
}
