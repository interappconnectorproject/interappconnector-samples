using InterAppConnector.DataModels;
using InterAppConnector.Interfaces;
using System.Reflection;

namespace BasicArgumentDefinitionRule.Library
{
    public class GenericRule : IArgumentDefinitionRule
    {
        public ParameterDescriptor DefineArgumentIfTypeDoesNotExist(object parentObject, PropertyInfo property, ParameterDescriptor descriptor)
        {

            return descriptor;
        }

        public ParameterDescriptor DefineArgumentIfTypeDoesNotExist(object parentObject, FieldInfo property, ParameterDescriptor descriptor)
        {
            return descriptor;
        }

        public ParameterDescriptor DefineArgumentIfTypeExists(object parentObject, FieldInfo field, ParameterDescriptor descriptor)
        {
            return descriptor;
        }

        public ParameterDescriptor DefineArgumentIfTypeExists(object parentObject, PropertyInfo property, ParameterDescriptor descriptor)
        {
            ActivityTracker? tracker = property.GetValue(parentObject) as ActivityTracker;
            if (tracker != null)
            {
                tracker.AddActivity("Executing generic definition rule contained in the library");
            }
            return descriptor;
        }

        public bool IsRuleEnabledInArgumentDefinition(PropertyInfo property)
        {
            return true;
        }

        public bool IsRuleEnabledInArgumentDefinition(FieldInfo field)
        {
            return true;
        }
    }
}
