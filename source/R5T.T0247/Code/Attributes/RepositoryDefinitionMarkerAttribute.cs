using System;

using R5T.T0143;


namespace R5T.T0247
{
    /// <summary>
    /// Attribute indicating an interface is a repository definition (a specialized service for persisting instances of data types).
    /// The marker attribute is useful for surveying repository definition interfaces and building a catalogue of repository definitions.
    /// Useful to also mark repositories with the service definition marker attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class RepositoryDefinitionMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsRepositoryDefinition;

        /// <summary>
        /// Allows specifying that an interface is *not* a repository definition interface.
        /// This is useful for marking interfaces that end up canonical repository definition code file locations, but are not repository definition interfaces.
        /// </summary>
        public bool IsRepositoryDefinition
        {
            get
            {
                return this.zIsRepositoryDefinition;
            }
        }


        public RepositoryDefinitionMarkerAttribute(
            bool isRepositoryDefinition = true)
        {
            this.zIsRepositoryDefinition = isRepositoryDefinition;
        }
    }
}
