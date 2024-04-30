using System;

using R5T.T0143;


namespace R5T.T0247
{
    /// <summary>
    /// Attribute indicating a class is a repository implementation (a specialized service for persisting instances of data types).
    /// The marker attribute is useful for surveying repository implementation classes and building a catalogue of repository implementations.
    /// Useful to also mark repositories with the service implementation marker attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class RepositoryImplementationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsRepositoryImplementation;

        /// <summary>
        /// Allows specifying that a class is *not* a repository implementation class.
        /// This is useful for marking classes that end up canonical repository implementation code file locations, but are not repository implementation classes.
        /// </summary>
        public bool IsRepositoryImplementation
        {
            get
            {
                return this.zIsRepositoryImplementation;
            }
        }


        public RepositoryImplementationMarkerAttribute(
            bool isRepositoryImplementation = true)
        {
            this.zIsRepositoryImplementation = isRepositoryImplementation;
        }
    }
}
