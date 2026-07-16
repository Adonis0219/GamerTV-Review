using System;
using System.Reflection;
using UnityEngine;

namespace SingletonTest6
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    SetupInstance();
                }
                return instance;
            }
        }

        static void SetupInstance()
        {
            instance = FindFirstObjectByType<T>();

            if (instance == null)
            {
                GameObject go = new GameObject();
                go.name = typeof(T).Name;
                instance = go.AddComponent<T>();
                DontDestroyOnLoad(go);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class SingletonAttribute : Attribute
    {
        public Type type;

        public SingletonAttribute(Type _type)
        {
            type = _type;
        }
    }

    // Attribute를 활용하여 DI
    public static class SingletonInjection
    {
        public static void Injection(object o)
        {
            Type type = o.GetType();

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var one in fields)
            {
                var attribute = (SingletonAttribute)one.GetCustomAttribute(typeof(SingletonAttribute));

                if (attribute == null) continue;

                var singletonType = attribute.type;

                var singleton = UnityEngine.Object.FindFirstObjectByType(singletonType);

                if (singleton == null)
                {
                    var property = singletonType.GetProperty("Instance", BindingFlags.Static
                                                 | BindingFlags.FlattenHierarchy
                                                 | BindingFlags.Public
                                                 | BindingFlags.GetProperty);

                    singleton = (UnityEngine.Object)property.GetValue(null, null);
                }
                
                one.SetValue(o, singleton);
            }
        }
    }
}