using Newtonsoft.Json;

namespace _UI.Models.ExtensionClasses
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key, object obj)
        {
            string ObjectString=JsonConvert.SerializeObject(obj);
            session.SetString(key, ObjectString);
        }
        public static T GetObject<T>(this ISession session,string key)where T : class 
        {
            string ObjectStiring=session.GetString(key);
            if (ObjectStiring == null)
            {
                return null;
            }
           T deserializedObject=JsonConvert.DeserializeObject<T>(ObjectStiring);
            return deserializedObject;  
        }
    }
}
