using System;
using System.Diagnostics;

namespace Tizen.Multimedia
{
    /// <summary>
    /// Represents a video plane for <see cref="MediaPacket"/>.
    /// This class is used if and only if the format of the packet is raw video.
    /// </summary>
    public class MediaPacketVideoPlane
    {
        private readonly MediaPacket _packet;
        private readonly int _strideWidth;
        private readonly int _strideHeight;
        private readonly MediaPacketBuffer _buffer;

        internal MediaPacketVideoPlane(MediaPacket packet, int index)
        {
            Debug.Assert(packet != null, "The packet is null!");
            Debug.Assert(!packet.IsDisposed, "Packet is already disposed!");
            Debug.Assert(index >= 0, "Video plane index must not be negative!");

            _packet = packet;

            int ret = Interop.MediaPacket.GetVideoStrideWidth(packet.GetHandle(), index, out _strideWidth);
            MediaToolDebug.AssertNoError(ret);

            ret = Interop.MediaPacket.GetVideoStrideWidth(packet.GetHandle(), index, out _strideHeight);
            MediaToolDebug.AssertNoError(ret);

            IntPtr dataHandle = IntPtr.Zero;
            ret = Interop.MediaPacket.GetVideoPlaneData(packet.GetHandle(), index, out dataHandle);
            MediaToolDebug.AssertNoError(ret);

            _buffer = new MediaPacketBuffer(packet, dataHandle, _strideWidth * _strideHeight);
        }

        /// <summary>
        /// Gets the buffer of the current video plane.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The MediaPacket that owns the current buffer already has been disposed of.</exception>
        public MediaPacketBuffer Buffer
        {
            get
            {
                _packet.EnsureReadableState();
                return _buffer;
            }
        }

        /// <summary>
        /// Gets the stride width of the current video plane.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The MediaPacket that owns the current buffer already has been disposed of.</exception>
        public int StrideWidth
        {
            get
            {
                _packet.EnsureReadableState();
                return _strideWidth;
            }
        }

        /// <summary>
        /// Gets the stride height of the current video plane.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The MediaPacket that owns the current buffer already has been disposed of.</exception>
        public int StrideHeight
        {
            get
            {
                _packet.EnsureReadableState();
                return _strideHeight;
            }
        }
    }
}
