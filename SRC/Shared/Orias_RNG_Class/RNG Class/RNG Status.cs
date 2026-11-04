using System;
using System.Collections.Generic;
using System.Text;

namespace Orias_RNG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>")]
    public partial class RNG
    {
        public enum RNG_Status
        {
            Success,    // The RNG was successfully generated
            Failure     // The RNG could not be generated
        }
    } // public partial class RNG
} // namespace Orias_RNG
