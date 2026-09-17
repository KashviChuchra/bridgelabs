using System;
using System.Collections.Generic;
using System.Text;

namespace AnnotationReflection.Annotation
{
    internal class LegacyApi
    {
        [Obsolete("This is Depreceated! Please use New feature")]
        public void OldFeature()
        {
            Console.WriteLine("Old feature");
        }
        public void NewFeature()
        {
            Console.WriteLine("New feature");
        }
    }
}
