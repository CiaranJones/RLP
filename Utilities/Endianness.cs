/*
 * From Jon Skeet's MiscUtil library http://www.yoda.arachsys.com/csharp/miscutil/
 */

namespace RLP.Utilities
{
    /// <summary>
    /// Endianness of a converter
    /// </summary>
    internal enum Endianness
    {
        /// <summary>
        /// Little endian - least significant byte first
        /// </summary>
        LittleEndian,
        /// <summary>
        /// Big endian - most significant byte first
        /// </summary>
        BigEndian
    }
}
