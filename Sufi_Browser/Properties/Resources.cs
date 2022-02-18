namespace Sufi_Browser.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
    internal class Resources
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        internal Resources()
        {
        }

        internal static Bitmap cil_arrow_left
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("cil-arrow-left", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static Bitmap icons8_console_32
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("icons8-console-32", resourceCulture);
            }
        }

        internal static Bitmap icons8_console_48
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("icons8-console-48", resourceCulture);
            }
        }

        internal static Bitmap icons8_console_64
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("icons8-console-64", resourceCulture);
            }
        }

        internal static Bitmap icons8_console_64__1_
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("icons8-console-64 (1)", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (resourceMan == null)
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("Sufi_Browser.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        internal static Icon sufi
        {
            get
            {
                return (Icon) ResourceManager.GetObject("sufi", resourceCulture);
            }
        }
    }
}

