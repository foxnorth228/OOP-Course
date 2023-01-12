using UnityEngine;

namespace StarMap
{
    [System.Serializable]
    public struct Star
    {
        public string name;
        public Vector3 position;
        public float magnitude;
        public float colorIndex;
    }

    [CreateAssetMenu(fileName = "stars", menuName = "StarData")]
    public class StarData : ScriptableObject
    {
        public Star[] stars;

        public void LoadFromDatabase(float magnitudeLimit)
        {
            stars = Starmap.LoadFromDatabase(magnitudeLimit);
        }
    }
}
