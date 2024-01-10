using InterAppConnector.DataModels;
using InterAppConnector.Interfaces;
using System.Reflection;

namespace BasicArgumentSettingRule.Library
{
    public class GenericRule : IArgumentSettingRule
    {
        public bool IsRuleEnabledInArgumentSetting(PropertyInfo property)
        {
            return true;
        }

        public bool IsRuleEnabledInArgumentSetting(FieldInfo field)
        {
            return true;
        }

        public ParameterDescriptor SetArgumentValueIfTypeDoesNotExist(object parentObject, PropertyInfo property, ParameterDescriptor argumentDescriptor, ParameterDescriptor userValueDescriptor)
        {
            return argumentDescriptor;
        }

        public ParameterDescriptor SetArgumentValueIfTypeDoesNotExist(object parentObject, FieldInfo property, ParameterDescriptor argumentDescriptor, ParameterDescriptor userValueDescriptor)
        {
            return argumentDescriptor;
        }

        public ParameterDescriptor SetArgumentValueIfTypeExists(object parentObject, PropertyInfo property, ParameterDescriptor argumentDescriptor, ParameterDescriptor userValueDescriptor)
        {
            ActivityTracker? tracker = property.GetValue(parentObject) as ActivityTracker;
            if (tracker != null)
            {
                tracker.AddActivity("Maximum row number set: " + userValueDescriptor.Value);
            }
            return argumentDescriptor;
        }

        public ParameterDescriptor SetArgumentValueIfTypeExists(object parentObject, FieldInfo property, ParameterDescriptor argumentDescriptor, ParameterDescriptor userValueDescriptor)
        {
            return argumentDescriptor;
        }
    }
}
