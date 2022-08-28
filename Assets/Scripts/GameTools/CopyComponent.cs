using UnityEngine;
using System;
using System.Reflection;

namespace GameTools
{
    // copied from https://answers.unity.com/questions/458207/copy-a-component-at-runtime.html

    public static class Reflection
    {
        public static Component CopyComponent(Component original, GameObject destination)
        {
            Type type = original.GetType();
            Component copy = destination.AddComponent(type);
            // Copied fields can be restricted with BindingFlags
            System.Reflection.FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);;

            foreach (System.Reflection.FieldInfo field in fields)
                field.SetValue(copy, field.GetValue(original));

            return copy;
        }

        public static T CopyComponentGeneric<T>(T original, GameObject destination) where T : Component
        {
            System.Type type = original.GetType();
            Component copy = destination.AddComponent(type);
            System.Reflection.FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);;

            foreach (System.Reflection.FieldInfo field in fields)
                field.SetValue(copy, field.GetValue(original));

            return copy as T;
        }
    }


}
