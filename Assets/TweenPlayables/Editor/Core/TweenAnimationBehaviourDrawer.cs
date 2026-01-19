using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TweenPlayables.Editor
{
    public abstract class TweenAnimationBehaviourDrawer : PropertyDrawer
    {
        protected abstract IEnumerable<string> GetPropertyNames();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
    
            EditorGUILayout.BeginVertical();
    
            foreach (var propertyName in GetPropertyNames())
            {
                var childProperty = property.FindPropertyRelative(propertyName);
                EditorGUILayout.PropertyField(childProperty);
                GUILayout.Space(5f);
            }
    
            EditorGUILayout.EndVertical();
    
            EditorGUI.EndProperty();
        }
    }
}
